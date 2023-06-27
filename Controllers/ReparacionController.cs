using ApiReparacion.Models;
using ApiReparacion.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiReparacion.Controllers
{
    [Route("/api/Reparacion")]
    [ApiController]
    public class ReparacionController:ControllerBase
    {
        IDetalleReparacionRepository detalle;
        IReparacionRepository reparacion;

        public ReparacionController(
            IReparacionRepository reparacion,
            IDetalleReparacionRepository detalle)
        {
            this.detalle = detalle;
            this.reparacion = reparacion;
        }

        [Route("/GetReparaciones")]
        [HttpGet]
        public async Task<ActionResult<ICollection<Reparacion>>>GetReparaciones()
        {
            return Ok(await reparacion.GetReparaciones());
        }
        [Route("/GetReparacionById")]
        [HttpGet]
        public async Task<ActionResult<Reparacion>>GetReparacionById(int id)
        {
            return Ok(await reparacion.GetReparacionById(id));
        }
        [Route("/CreateReparacion")]
        [HttpPost]
        public async Task<ActionResult<Reparacion>>CreateReparacion([FromBody] Reparacion rep)
        {
            return StatusCode(StatusCodes.Status201Created, 
                await reparacion.CreateReparacion(rep));
        }
        [Route("/UpdateReparacion")]
        [HttpPut]
        public async Task<ActionResult<Reparacion>>UpdateReparacion([FromBody] Reparacion rep)
        {
            return Ok(await reparacion.UpdateReparacion(rep));
        }
        [Route("/DeleteReparacion/{id}")]
        [HttpDelete]
        public async Task<ActionResult<bool>>DeleteReparacion([FromRoute]int id)
        {
            return Ok(await reparacion.DeleteReparacion(id));
        }
        
        
        [Route("/GetDetalles")]
        [HttpGet]
        public async Task<ActionResult<ICollection<DetalleReparacion>>> GetDetalles()
        {
            return Ok(await detalle.GetDetalles());
        }

        [Route("/GetDetallesByReparacionId/{id}")]
        [HttpGet]
        public async Task<ActionResult<ICollection<DetalleReparacion>>>GetDetallesByReparacionId([FromRoute]int id)
        {
            return Ok(await detalle.GetDetallesByReparacionId(id));
        }
        [Route("/GetDetalleById")]
        [HttpGet]
        public async Task<ActionResult<DetalleDto>> GetDetalleById(int id)
        {
            return Ok(await detalle.GetDetalleById(id));
        }
        [Route("CreateDetalle")]
        [HttpPost]
        public async Task<ActionResult<DetalleReparacion>>CreateDetalle([FromBody] DetalleReparacion dt)
        {
            return StatusCode(StatusCodes.Status201Created,
                await detalle.CreateDetalle(dt));
        }
        [Route("/UpdateDetalle")]
        [HttpPut]
        public async Task<ActionResult<DetalleReparacion>>UpdateDetalle([FromBody]DetalleReparacion dt)
        {
            return Ok(await detalle.UpdateDetalle(dt));
        }
        [Route("/DeleteDetalle")]
        [HttpDelete]
        public async Task<ActionResult<bool>>DeleteDetalle(int id)
        {
            return Ok(await detalle.DeleteDetalle(id));
        }
    }
}
