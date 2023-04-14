using Linea_Denuncia_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Linea_Denuncia_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenunciasSPController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public DenunciasSPController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("SP")]
        public async Task<ActionResult<List<DenunciaSP>>> getDenunciasSP()
        {
            try
            {
                var denuncias = await _context.DenunciaSP.FromSqlRaw("getDenuncias").ToListAsync();
                return Ok(denuncias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

    }
}
