using APIProductos.Data;
using APIProductos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        private readonly ApplicationDBContext _db;

        public EmpleadoController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Empleados> products = await _db.Empleados.ToListAsync();
            return Ok(products);
        }

        // GET api/<ProductoController>/5
        [HttpGet("{Cedula}")]
        public async Task<IActionResult> Get(string Cedula)
        {
            Empleados producto = await _db.Empleados.FirstOrDefaultAsync(x=>x.Cedula == Cedula);
            if(producto == null) {
                return BadRequest();
            }
            return Ok(producto);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Empleados empleado)
        {
            Empleados pEncontrado = await _db.Empleados.FirstOrDefaultAsync(x => x.Cedula == empleado.Cedula);

            if( pEncontrado == null && empleado != null)
            {

                await _db.Empleados.AddAsync(empleado);
                await _db.SaveChangesAsync();
                return Ok(empleado);

            }

            return BadRequest();
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{Cedula}")]
        public async Task<IActionResult> Put(int IdProductos, [FromBody] Empleados empleados)
        {

            Empleados pEncontrado = await _db.Empleados.FirstOrDefaultAsync(x => x.Cedula == empleados.Cedula);

            if (pEncontrado != null)
            {
                pEncontrado.Nombre = empleados.Nombre != null ? empleados.Nombre : pEncontrado.Nombre;
                pEncontrado.Apellido = empleados.Apellido != null ? empleados.Apellido : pEncontrado.Apellido;
                pEncontrado.Edad = empleados.Edad != 0 ? empleados.Edad : pEncontrado.Edad;
                _db.Update(pEncontrado);
                await _db.SaveChangesAsync();
                return Ok(pEncontrado);
            }


            return BadRequest();
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{Cedula}")]
        public async Task<IActionResult> Delete(string cedula)
        {

            Empleados pEncontrado = await _db.Empleados.FirstOrDefaultAsync(x => x.Cedula == cedula);


            if (pEncontrado != null)
            {
                _db.Empleados.Remove(pEncontrado);
                await _db.SaveChangesAsync();
                return NoContent(); 
            }

            return BadRequest();
        }
    }
}
