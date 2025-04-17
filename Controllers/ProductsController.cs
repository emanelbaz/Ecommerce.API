using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string getProducts()
        {
            return "this will be list of products";
        }
        [HttpGet("{id}")]
        public string getProduct(int id) {
            return "single product";
        }

    }
}
