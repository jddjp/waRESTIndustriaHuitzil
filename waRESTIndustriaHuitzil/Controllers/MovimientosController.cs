using CoreIndustriaHuitzil.Models;
using CoreIndustriaHuitzil.ModelsRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceIndustriaHuitzil.Services;

namespace waRESTIndustriaHuitzil.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {
        private readonly IIndustriaHuitzilService _service;
        public MovimientosController(IIndustriaHuitzilService service) => _service = service;

        #region GET
        [HttpGet("Movimientos")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetMovimientos()
        {
            return Ok(await _service.getMovimientos());
        }

        [HttpGet("MovimientosArticulos")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetMovimientosArticulos()
        {
            return Ok(await _service.getMovimientosArticulos());
        }

        [HttpPost("Add")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> AgregaMovimiento([FromBody] MovimientoInvetarioRequest request)
        {
            return Ok(await _service.addMovimientoInventario(request));
        }

        [HttpPost("cerrar")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> cerrarMovimiento([FromBody] MovimientoInvetarioRequest request)
        {
            return Ok(await _service.updateMovimientoInventario(request));
        }

        //[HttpGet("ConsultaAllVR")]
        //[Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        //public async Task<IActionResult> GetVistasRoles(int idRol)
        //{
        //    return Ok(await _service.getVistasRol(idRol));
        //}
        //#endregion

        //#region POST
        //[HttpPost("AgregaVR")]
        //[Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        //public async Task<IActionResult> AgregarVR([FromBody] VistaRolRequest request)
        //{
        //    return Ok(await _service.postVistaRol(request));
        //}
        //#endregion

        //#region PUT
        //[HttpPut("ActualizaVR")]
        //[Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        //public async Task<IActionResult> ActualizaVR([FromBody] VistaRolRequest request)
        //{
        //    return Ok(await _service.putVistaRol(request));
        //}
        //#endregion

        //#region DELETE
        //[HttpDelete("EliminaVR")]
        //[Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        //public async Task<IActionResult> EliminaVR([FromBody] VistaRolRequest request)
        //{
        //    return Ok(await _service.deleteVistaRol(request));
        //}
        #endregion
    }
}
