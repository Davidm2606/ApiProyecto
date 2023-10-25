using APIProductos.Data;
using APIProductos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlimentoController : ControllerBase
    {

        private readonly ApplicationDBContext _db;

        public AlimentoController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Producto> products = await _db.Productos.ToListAsync();
            return Ok(products);
        }

        // GET api/<ProductoController>/5
        [HttpGet("{IdProducto}")]
        public async Task<IActionResult> Get(int IdProducto)
        {
            Producto producto = await _db.Productos.FirstOrDefaultAsync(x=>x.IdProducto == IdProducto);
            if(producto == null) {
                return BadRequest();
            }
            return Ok(producto);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Producto producto)
        {
            Producto pEncontrado = await _db.Productos.FirstOrDefaultAsync(x => x.IdProducto == producto.IdProducto);

            if( pEncontrado == null && producto != null)
            {

                await _db.Productos.AddAsync(producto);
                await _db.SaveChangesAsync();
                return Ok(producto);

            }

            return BadRequest();
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{IdProductos}")]
        public async Task<IActionResult> Put(int IdProductos, [FromBody] Producto producto)
        {

            Producto pEncontrado = await _db.Productos.FirstOrDefaultAsync(x => x.IdProducto == producto.IdProducto);

            if (pEncontrado != null)
            {
                pEncontrado.Nombre = producto.Nombre != null ? producto.Nombre : pEncontrado.Nombre;
                pEncontrado.Valor = producto.Valor != null ? producto.Valor : pEncontrado.Valor;
                pEncontrado.Cantidad = producto.Cantidad != null ? producto.Cantidad : pEncontrado.Cantidad;
                _db.Update(pEncontrado);
                await _db.SaveChangesAsync();
                return Ok(pEncontrado);
            }


            return BadRequest();
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{IdProducto}")]
        public async Task<IActionResult> Delete(int IdProducto)
        {

            Producto pEncontrado = await _db.Productos.FirstOrDefaultAsync(x => x.IdProducto == IdProducto);


            if (pEncontrado != null)
            {
                _db.Productos.Remove(pEncontrado);
                await _db.SaveChangesAsync();
                return NoContent(); 
            }

            return BadRequest();
        }
    }
}
