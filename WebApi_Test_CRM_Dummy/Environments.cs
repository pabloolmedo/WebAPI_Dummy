using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Test_CRM_Dummy
{
    public static class Environments
    {



        /// <summary>
        /// Metodo que obtiene variable de entorno
        /// </summary>
        /// <returns></returns>
        public static string GetVariable()
        {
            string value;
            // Check whether the environment variable exists.
            value = Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT", EnvironmentVariableTarget.Machine);

            return value;



        }
    }
}
