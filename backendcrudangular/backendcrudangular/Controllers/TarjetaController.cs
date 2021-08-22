using backendcrudangular.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backendcrudangular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        public readonly AplicationDbContext _context;
        public TarjetaController(AplicationDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                var lisTarjetas =await  _context.TarjetaCredito.ToListAsync();
                return Ok(lisTarjetas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<TarjetaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Tarjeta value)
        {
            try
            {
                _context.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Tarjeta value)
        {
            try
            {
                if (id != value.Id) 
                {
                    return NotFound();

                }

                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(new { message = "La tarjeta fue actualizada con exito" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var tarjeta = await _context.TarjetaCredito.FindAsync(id);
                if (tarjeta == null) 
                {
                    return NotFound();
                }
                _context.TarjetaCredito.Remove(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(new { message ="La tarjeta fue eliminada con exito"});
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
