using CoreIndustriaHuitzil.ModelsRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceIndustriaHuitzil.Services;

namespace waRESTIndustriaHuitzil.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        private readonly IIndustriaHuitzilService _service;
        public InventarioController(IIndustriaHuitzilService service) => _service = service;

        #region GET
        [HttpGet("Consulta")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetProductos(string sucursal)
        {
            return Ok(await _service.getProductos(sucursal));
        }

        [HttpGet("SearchProduct")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> SearchProduct(string queryString, string sucursal)
        {
            return Ok(await _service.searchProduct(queryString, sucursal));
        }

        [HttpGet("SearchProductDemanda")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> SearchProductDemanda(string queryString, string sucursal, int page = 0, int size = 10, string sku = null, string categoria = null, string talla = null, string ubicacion = null)
        {
            var filters = new SearchProductFilters
            {
                //QueryString = queryString,
                //Sucursal = sucursal,
                //SKU = sku,
                //Descripcion = descripcion,
                Categoria = categoria,
                Talla = talla,
                Ubicacion = ubicacion,
                Page = page,
                Size = size
            };

            var result = await _service.SearchProductDemanda(filters);

            return Ok(result);
        }



        [HttpGet("SearchProductFilterUbicacion")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> SearchProductFilterUbicacion(string sucursal)
        {
            return Ok(await _service.SearchProductFilterUbicacion( sucursal));
        }



        [HttpGet("Inexistencias")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetInexistencias(string sucursal)
        {
            return Ok(await _service.getInexistencias(sucursal));
        }
        #endregion

        #region POST
        [HttpPost("Agrega")]
        public async Task<IActionResult> AgregaProducto([FromBody] ProductoRequest request)
        {
            return Ok(await _service.postProductos(request));
        }
        [HttpPost("AgregaCarga")]
        public async Task<IActionResult> AgregaProducto([FromBody] ProductoRequest request)
        {
            return Ok(await _service.postProductos(request));
        }
        #endregion

        #region PUT
        [HttpPut("Actualiza")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> ActualizaProducto([FromBody] ProductoRequest request)
        {
            return Ok(await _service.putProductos(request));
        }
        #endregion

        #region DELETE
        [HttpDelete("Elimina")]
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> EliminaProducto([FromBody]ProductoRequest request)
        {
            return Ok(await _service.deleteProductos(request));
        }
        #endregion
    }
}
