using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using log4net;
using System.IO;
using WebApi_Test_CRM_Dummy;

namespace WebApi_Test_CRM_Dummy.Controllers
{




    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class DummyController : ApiController
    {
        //VALIDACION DE ENTORNO
        string entorno = RuntimeVariableEnvironmentTest.GetVariable();
        

        private static readonly log4net.ILog logger =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);




        [HttpGet]
        public object GetTest()
        {
            //VALIDAR ENTORNO "DESA"
            if (entorno == "DESA")
            {
            

                //LOGS
                logger.Info("Iniciando");
                try
                {
                    logger.Info("entro al try");
                    object empleado = new
                    {
                        Fullname = "Dummy Test",
                        address = "rivera indarte 650",

                    };

                    logger.Info("");
                    return empleado;

                }
                catch (Exception ex)
                {
                    logger.Error("ERROR" + HttpStatusCode.NotFound.ToString() + ex.ToString());
                    throw;
                }

            }
            else
            {
                throw new Exception("AMBIENTE INCORRECTO");
            }
        }


    }


}
