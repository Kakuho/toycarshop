using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VroomVroom.Data;
using VroomVroom.Models;
using VroomVroom.DataStructures;

namespace VroomVroom.Controllers
{

    //[Route("api/[controller]")]
    [Route("api/[controller]/[action]")] /* if you want to do PaginatedProduct/GetProducts ect */
    [ApiController]
    public class PaginatedProductController : ControllerBase
    {
        private readonly CarContext _context;

        private int pageSize = 8;

        public PaginatedProductController(CarContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> Products()
        {
            return await _context.Cars.ToListAsync();
        }

        public enum sortOrder{
          priceAscending,
          priceDescending,
          nameAscending,
          nameDescending
        };

        // GET: api/Product/5
        [HttpGet]
        public async Task<ActionResult<PaginatedList<Car>>> ProductPage(int? page, sortOrder? sort, Category? category, int? lowPrice, int? highPrice)
        {
            var products = from p in _context.Cars
                           select p;
            if(category.HasValue){
              products = products.Where(p => p.Category == category);
            }
            if(sort.HasValue){
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
            }

            products = products.Where( p => (p.Price >= (lowPrice??0)) && (p.Price <= (highPrice??1000)));
            return await PaginatedList<Car>.CreateAsync(products, page??1, pageSize);
        }

        // GET: api/Product/ProductPage/demo?
        [HttpGet("demo")]
        public async Task<ActionResult<PaginatedList<Car>>> ProductPage(int? page, string? sort, string? category, int? lowPrice, int? highPrice){
            var products = from p in _context.Cars
                           select p;
            if(!String.IsNullOrEmpty(category)){
              switch(category){
                case "basic":
                  products = products.Where(p => p.Category == Category.Basic);
                  break;
                case "fruit":
                  products = products.Where(p => p.Category == Category.Fruit);
                  break;
                case "metal":
                  products = products.Where(p => p.Category == Category.Metal);
                  break;
                case "special":
                  products = products.Where(p => p.Category == Category.Special);
                  break;
                case "greek-god":
                  products = products.Where(p => p.Category == Category.GreekGod);
                  break;
                case "na":
                  products = products.Where(p => p.Category == Category.NA);
                  break;
                default:
                  throw new Exception("ayo you crashed the server");
              }
            }
            if(!String.IsNullOrEmpty(sort)){
              switch(sort){
                case "price-asc":
                  products = products.OrderBy(p => p.Price);
                  break;
                case "price-desc":
                  products = products.OrderByDescending(p => p.Price);
                  break;
                case "name-asc":
                  products = products.OrderBy(p => p.Name);
                  break;
                case "name_desc":
                  products = products.OrderByDescending(p => p.Name);
                  break;
                default:
                  throw new Exception("ayo you crashed the server");
              }
            }
            products = products.Where( p => (p.Price >= (lowPrice??0)) && (p.Price <= (highPrice??1000)));
            return await PaginatedList<Car>.CreateAsync(products, page??1, pageSize);
        }

        public class PagesInformation{
          public int TotalPages {get; set;}
          public int TotalNumberOfProducts{get; set;}
          public int ProductsPerPage {get; set;}
        }
  
        [HttpGet]
        public async Task<PagesInformation> Information(){
            // linq very beautiful
            var products = from p in _context.Cars
                           select p;
            
            var count = await products.CountAsync();
            PagesInformation dto = new PagesInformation
            {
              TotalPages = (int)Math.Ceiling(count/(double)pageSize),
              TotalNumberOfProducts = count,
              ProductsPerPage = pageSize
            };

            return dto;
        }
    }
}
