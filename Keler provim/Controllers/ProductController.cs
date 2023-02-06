using AspNetCoreWebAPI.Models;
using AspNetCoreWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductService _productService;
        public ProductController(ProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._productService.GetProducts());
        }

        [HttpPost]
        public ActionResult Post(Product product)
        {
            this._productService.AddProduct(product);
            return Ok();
        }
    }
}