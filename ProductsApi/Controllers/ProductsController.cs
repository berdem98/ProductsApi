using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsContext _context;

        public ProductsController(ProductsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int? id)
        {
            if (id == null)
                return NotFound();
            var product = await _context.Products.FirstOrDefaultAsync(i=>i.ProductId == id);
            if (product == null)
                return NotFound();
            return Ok(product);
            
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new {id=product.ProductId}, product);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if(id != product.ProductId)
                return BadRequest();
            var p = await _context.Products.FirstOrDefaultAsync(p=>p.ProductId == id);
            if (p == null)
                return NotFound();
            p.ProductName = product.ProductName;
            p.Price = product.Price;
            p.IsActive = product.IsActive;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                return NotFound();
            }
            return NoContent();
        }
    }
}
