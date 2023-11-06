using APIProductos.Data;
using APIProductos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatoController : ControllerBase
    {

        private readonly ApplicationDBContext _db;
        

        public PlatoController(ApplicationDBContext db)
        {
            _db = db;
           
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Platos> products = await _db.Platos.ToListAsync();
            return Ok(products);
        }

        // GET api/<ProductoController>/5
        [HttpGet("{IdPlato}")]
        public async Task<IActionResult> Get(int IdPlato)
        {
            Platos producto = await _db.Platos.FirstOrDefaultAsync(x => x.IdPlato == IdPlato);
            if (producto == null)
            {
                return BadRequest();
            }
            return Ok(producto);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Platos plato)
        {
            try
            {
                foreach (var ingrediente in plato.Ingredientes.Split(','))
                {
                    var producto = await _db.Productos.FirstOrDefaultAsync(x => x.Nombre == ingrediente.Trim());

                    if (producto != null)
                    {
                        if (producto.Cantidad >= plato.Cantidad)
                        {
                            var papas = await _db.Productos.FirstOrDefaultAsync(x => x.Nombre == "papas");
                            producto.Cantidad -= plato.Cantidad;
                            papas.Cantidad -= 200;
                           

                            if (plato.Nombre.Equals("papas", StringComparison.OrdinalIgnoreCase))
                            {

                                producto.Cantidad -= 200;

                            }
                            else if (plato.Nombre.Equals("hamburguesas", StringComparison.OrdinalIgnoreCase))
                            {
                               
                                var lechuga = await _db.Productos.FirstOrDefaultAsync(x => x.Nombre == "lechuga");
                                var tomate = await _db.Productos.FirstOrDefaultAsync(x => x.Nombre == "tomate");
                                var pan = await _db.Productos.FirstOrDefaultAsync(x => x.Nombre == "pan");

                                if (lechuga != null && tomate != null && pan != null)
                                {
                                    lechuga.Cantidad -= 25;
                                    tomate.Cantidad -= 25;
                                    pan.Cantidad -= 1;

                                    
                                    _db.Update(lechuga);
                                    _db.Update(tomate);
                                    _db.Update(pan);
                                }
                                else
                                {
                                    return BadRequest(new { message = "No se encontraron los ingredientes necesarios para la hamburguesa." });
                                }
                            }

                            
                            _db.Update(producto);
                        }
                        else
                        {
                            return BadRequest(new { message = $"No hay suficiente cantidad de {ingrediente} en la tabla de productos." });
                        }
                    }
                    else
                    {
                        return BadRequest(new { message = $"El ingrediente {ingrediente} no está registrado en la tabla de productos." });
                    }
                }

               
                await _db.Platos.AddAsync(plato);
                await _db.SaveChangesAsync();

                return Ok(new { message = "Plato agregado exitosamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"Error interno del servidor: {ex.Message}" });
            }
        }






        // PUT api/<ProductoController>/5
        [HttpPut("{IdPlato}")]
        public async Task<IActionResult> Put(int IdPlato, [FromBody] Platos plato)
        {

            Platos pEncontrado = await _db.Platos.FirstOrDefaultAsync(x => x.IdPlato == plato.IdPlato);

            if (pEncontrado != null)
            {
                pEncontrado.Nombre = plato.Nombre != null ? plato.Nombre : pEncontrado.Nombre;
                pEncontrado.Ingredientes = plato.Ingredientes != null ? plato.Ingredientes : pEncontrado.Ingredientes;
                pEncontrado.Precio = plato.Precio != 0 ? plato.Precio : pEncontrado.Precio;
                _db.Update(pEncontrado);
                await _db.SaveChangesAsync();
                return Ok(pEncontrado);
            }


            return BadRequest();
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{IdPlato}")]
        public async Task<IActionResult> Delete(int IdPlato)
        {

            Platos pEncontrado = await _db.Platos.FirstOrDefaultAsync(x => x.IdPlato == IdPlato);


            if (pEncontrado != null)
            {
                _db.Platos.Remove(pEncontrado);
                await _db.SaveChangesAsync();
                return NoContent();
            }

            return BadRequest();
        }
    }
}
