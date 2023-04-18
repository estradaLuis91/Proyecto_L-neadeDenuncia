using Linea_Denuncia_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

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

        [HttpPut]  
        
        public async  Task<IActionResult> put(Update_Status status)
        {
            try
            {

                await _context.Database.
                    ExecuteSqlAsync($@"EXEC dbo.Update_Status_Denuncia
                                                @id_Denuncia={status.Denuncia_Id} ,@status ={status.Status}");
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpGet("Folio")]

        public async Task<IActionResult> createFolio()
        {
            try
            {
                var getfolio = new SqlParameter("@folio",SqlDbType.Int);
                getfolio.Direction = ParameterDirection.Output;

                await _context.Database.
                    ExecuteSqlInterpolatedAsync($@"EXEC [dbo].[Insert_Folio] {getfolio} OUTPUT");

                var folio = (int)getfolio.Value;
                return Ok(folio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }



        [HttpPost]
        public async Task<ActionResult<List<Status_Denuncia>>> postDenuncia(Status_Denuncia denuncia)
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


        [HttpPost("SP")]
        public async Task<ActionResult<List<DenunciaSP>>> updateDenunciasSP(int Id_Denuncia , string status)
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
