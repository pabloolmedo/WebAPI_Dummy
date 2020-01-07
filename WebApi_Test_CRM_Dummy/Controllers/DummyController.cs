using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using log4net;
using System.IO;

namespace WebApi_Test_CRM_Dummy.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class DummyController : ApiController
    {


        private static readonly log4net.ILog logger =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //localhost:44372/api/Dummy
        // GET: api/Dummy
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Dummy", "Test" };
        //}

        //localhost:44372/api/Dummy

        [HttpGet]
        public object Get()
        {

            logger.Info("Iniciando");
            try
            {
                logger.Info("entro al try");
                object empleado = new
                {
                    Fullname = "Dummy Test",
                    address = "rivera indarte 650",

                };
                logger.Info("Fin");
                return empleado;

            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }
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
