using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi_Test_CRM_Dummy.Models;

namespace WebApi_Test_CRM_Dummy.Controllers
{
    public class WebApi_UnitTestController : ApiController
    {
        List<WebApi_Test> products = new List<WebApi_Test>();

        public WebApi_UnitTestController() { }

        public WebApi_UnitTestController(List<WebApi_Test> products)
        {
            this.products = products;
        }

        public IEnumerable<WebApi_Test> GetAllProducts()
        {
            return products;
        }

        public async Task<IEnumerable<WebApi_Test>> GetAllProductsAsync()
        {
            return await Task.FromResult(GetAllProducts());
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public async Task<IHttpActionResult> GetProductAsync(int id)
        {
            return await Task.FromResult(GetProduct(id));
        }
    }
}

