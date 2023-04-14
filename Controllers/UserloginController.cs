using Linea_Denuncia_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Linea_Denuncia_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserloginController : ControllerBase

    {
        private readonly AplicationDbContext _context;

        public UserloginController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Userlogin>>> getUsuario()
        {
            try{
                var user = await _context.Users.ToListAsync();
                return Ok(user);
            }
            catch(Exception ex){ 
                return BadRequest(ex.Message);
            }


            }
    }
}
