using AspNetWebApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetWebApi2.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] {
            new Product { Id = 1, Name = "Tomato Soup", Categoty = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Categoty = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Categoty = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts() {
            return products;
        }

        public IHttpActionResult GetProduct(int id) {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
