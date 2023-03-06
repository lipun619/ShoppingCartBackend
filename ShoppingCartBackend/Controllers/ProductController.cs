using Microsoft.AspNetCore.Mvc;
using ShoppingCartBackend.BusinessComponent.IService;
using System.Net;

namespace ShoppingCartBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;
        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            try
            {
                return Ok(_productService.GetAllProducts());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(HttpStatusCode.InternalServerError);
            }
        }
    }
}
