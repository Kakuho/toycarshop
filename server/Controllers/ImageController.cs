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
    public class ImageController : ControllerBase
    {
        private readonly ProductContext _context;

        public ImageController(ProductContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ContentResult> GetImage(int i)
        {
          ContentResult response = new ContentResult();
          if(i == 1){
            response.Content = "Hello world!";
            response.ContentType = "text/html";
            response.StatusCode = 200;
          }
          else if(i == 2){
            byte[] b = await System.IO.File.ReadAllBytesAsync("./Controllers/hello.txt");
            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
            response.Content = encoder.GetString(b);
            response.ContentType = "text";
            response.StatusCode = 200;
          }
          else if(i == 3){
            // serving images in html
            byte[] b = await System.IO.File.ReadAllBytesAsync("./Assets/cars/1_redcar.svg");
            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
            response.Content = encoder.GetString(b);
            response.ContentType = "image/svg+xml";
            response.StatusCode = 200;
          }
          return response;
        }
    }
}
*/
