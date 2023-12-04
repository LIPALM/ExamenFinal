using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvionesCrontole : ControllerBase
    {
        private readonly ILogger<AvionesCrontole> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public AvionesCrontole(
            ILogger<AvionesCrontole> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Aviones aviones)
        {
            _aplicacionContexto.Aviones.Add(aviones);
            _aplicacionContexto.SaveChanges();
            return Ok(aviones);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Aviones> Get()
        {
            return _aplicacionContexto.Aviones.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Aviones aviones)
        {
            _aplicacionContexto.Aviones.Update(aviones);
            _aplicacionContexto.SaveChanges();
            return Ok(aviones);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int avionID)
        {
            _aplicacionContexto.Aviones.Remove(
                _aplicacionContexto.Aviones.ToList()
                .Where(x=>x.idAvion == avionID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(avionID);
        }
    }
}