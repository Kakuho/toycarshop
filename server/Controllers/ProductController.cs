/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductStore.Data;
using ProductStore.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase{
        private readonly ProductContext _context;

        public ProductController(ProductContext context){
          _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(){
          return await _context.Products.ToListAsync();
        }

        public enum sortOrder{
          priceAscending,
          priceDescending,
          nameAscending,
          nameDescending
        };

        // GET: api/Product?id=&sort=&
        /*
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(long id, sortOrder? sort){
            var products = from f in _context.Products
                           select f;
            switch(sort){
              case sortOrder.priceAscending:
                products = products.OrderBy(p => p.Price);
                break;
              case sortOrder.priceDescending:
                products = products.OrderByDescending(p => p.Price);
                break;
              case sortOrder.nameAscending:
                products = products.OrderBy(p => p.Name);
                break;
              case sortOrder.nameDescending:
                products = products.OrderByDescending(p => p.Name);
                break;
            }
            var product = await _context.Products.FindAsync(id);
            if (product == null){
              return NotFound();
            }
            return product;
        }
        */

        /*
        // PUT: api/Product/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(long id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Product
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(long id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
*/
