using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi_Test_CRM_Dummy.Controllers
{
    [EnableCors(origins: "*", headers:"*", methods:"*")]
    public class DummyController : ApiController
    {
        //localhost:44372/api/Dummy
        // GET: api/Dummy
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Dummy", "Test" };
        //}
       [HttpGet]
        public object  Get()
        {
           object empleado = new {
               Fullname = "Dummy Test",
               address = "rivera indarte 650",

                };

            return empleado;
        }
        // GET: api/Dummy/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Dummy
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dummy/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dummy/5
        public void Delete(int id)
        {
        }
    }
}
