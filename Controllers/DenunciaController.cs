using Linea_Denuncia_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Linea_Denuncia_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenunciaController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public DenunciaController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Denuncia>>> getState()
        {
            try
            {
                var denuncias = await _context.Denuncia.ToListAsync();
                return Ok(denuncias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

   

        [HttpPost]
        public async Task<ActionResult<List<Denuncia>>> postDenuncia(Denuncia denuncia)
        {
            try
            {
                _context.Add(denuncia);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
