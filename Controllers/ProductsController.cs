using Ecommerce.Core.Models;
using Ecommerce.EF.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly Context _context;
        public ProductsController(Context context) {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProducts()
        {
            var products= await _context.Products.ToListAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> getProduct(int id) {
            return await _context.Products.FindAsync(id);
        }

    }
}
