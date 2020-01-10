using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Test_CRM_Dummy
{
    public static class RuntimeVariableEnvironmentTest
    {



        /// <summary>
        /// Metodo que obtiene variable de entorno
        /// </summary>
        /// <returns></returns>
        public static string GetVariable()
        {

            string value;
            try
            {

                // Check whether the environment variable exists.
                value = Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT", EnvironmentVariableTarget.Machine);
                // If necessary, create it.
                //if (value == null)
                //{
                //    Environment.SetEnvironmentVariable("RUNTIME_ENVIRONMENT", "DESA", EnvironmentVariableTarget.Machine);
                //    // Now retrieve it.
                //    value = Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT");
                //}
                return value;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
