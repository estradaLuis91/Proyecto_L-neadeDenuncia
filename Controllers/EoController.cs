using Linea_Denuncia_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Linea_Denuncia_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EoController : ControllerBase
    {

        private readonly AplicationDbContext _context;

        public EoController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Eo>>>getEo()
        {
            try
            {
                var eo = await _context.Eos.ToListAsync();
                return Ok(eo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
