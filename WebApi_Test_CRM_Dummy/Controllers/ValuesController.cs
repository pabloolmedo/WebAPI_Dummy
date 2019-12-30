using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Test_CRM_Dummy.Models;

namespace WebApi_Test_CRM_Dummy.Controllers
{
    public class ValuesController : ApiController
    {
        List<Books> books = new List<Books>();

        public ValuesController() { }

        public ValuesController(List<Books> books)
        {
            this.books = books;
        }



        // GET api/values
        public List<string> Get()
        {

            return new List<string> { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        //GET api/values/?id=5
        public IHttpActionResult GetBook(int id)
        {
            var book = books.FirstOrDefault((p) => p.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
