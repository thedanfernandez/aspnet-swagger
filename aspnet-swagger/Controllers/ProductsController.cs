using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_swagger.Controllers
{
    /// <summary>
    /// Service to return products in a product catalog
    /// </summary>
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        /// <summary>
        /// Returns the full list of all products. Called using /hostname/ + /api/Products/
        /// </summary>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            Product p1 = new Product() { ID = 1, Name = "Book 1", Price = 1, Description = "Part 1 Learn to program" };
            Product p2 = new Product() { ID = 2, Name = "Book 2", Price = 2, Description = "Part 2 Learn to program" };
            Product p3 = new Product() { ID = 3, Name = "Book 3", Price = 3, Description = "Part 3 Learn to program" };

            var x = new List<Product>();
            x.Add(p1);
            x.Add(p2);
            x.Add(p3);
            return x;

        }

        /// <summary>
        /// Returns a product with a given Product IDs. Called using /hostname/ + /api/Products/ID
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /hostname/api/products/1
        /// </remarks>
        /// <returns>A Product JSON object like this example 
        /// { "id":1,
        ///  "name":"Book 1",
        ///  "price":1,
        ///  "description":"Learn to program"
        /// }
        ///</returns>

        /// <param name="id">a sequential integer unique identifier for the product.</param>    
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            //normally this would be a product lookup
            return new Product() { ID = id, Name = "Book " + id.ToString(), Price = id, Description = "Learn to program" };
        }


    }
}
