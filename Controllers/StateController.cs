using Linea_Denuncia_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Linea_Denuncia_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public StateController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<State>>> getState()
        {
            try
            {
                var state = await _context.States.ToListAsync();
                return Ok(state);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }

}

