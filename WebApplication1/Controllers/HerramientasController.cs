using HerramientasApi.Data.ModelVM;
using HerramientasApi.Models;
using HerramientasApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HerramientasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //
    public class HerramientasController : ControllerBase
    {
        private readonly IHerramientasService _herramientasService;
        public HerramientasController(IHerramientasService herramientasService)
        {
            _herramientasService = herramientasService;
        }

        [HttpGet]
        public IActionResult Get()
        {
          List<Herramienta> herramientas= _herramientasService.ObtenerHerramientas();
          return Ok(herramientas);
        }

        [HttpPost]
        public IActionResult Post( HerramientaVM herramienta)
        { 
            Herramienta herramientaAdd= new Herramienta()
            {
                TipoHerramienta= herramienta.TipoHerramienta,
                Disponibilidad= herramienta.Disponibilidad,
                NombreReservante= herramienta.NombreReservante,
                ApellidoReservante = herramienta.ApellidoReservante,
                Dni = herramienta.Dni,
                Direccion = herramienta.Direccion
            };

            _herramientasService.CrearHerramienta(herramientaAdd);
            return Ok("Product added successfully");
        }

        [HttpPut]
        [Route("updateProduct")]
        public IActionResult Put(int id, [FromBody] Herramienta herramienta)
        {
            
            _herramientasService.EditarHerramienta(id, herramienta);
            return Ok("Product updated  sucessfully ");
        }

        [HttpGet]
        [Route("Herramienta")]

        public IActionResult ObtenerProductoPorId(int id)
        {
            Herramienta herramienta = _herramientasService.ObtenerHerramientaPorId(id);
            return Ok(herramienta);
        }

        [HttpDelete]
        [Route("Herramienta")]

        public IActionResult BorrarHerramienta(int id)
        {
            Herramienta herramientaBorrar = _herramientasService.ObtenerHerramientaPorId(id);
            _herramientasService.EliminarHerramienta(herramientaBorrar.Id, herramientaBorrar);
            return Ok("The product was deleted");
        }


    }
}
