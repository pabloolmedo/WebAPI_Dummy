using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Test_CRM_Dummy
{
    public class RuntimeVariableEnvironmentTest
    {
        public  string GetVariable()
        {
            string value;

            // Check whether the environment variable exists.
            value = Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT", EnvironmentVariableTarget.Machine);

            // If necessary, create it.
            if (value == null)
            {
                Environment.SetEnvironmentVariable("RUNTIME_ENVIRONMENT", "DESA", EnvironmentVariableTarget.Machine);


                // Now retrieve it.
                value = Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT");
            }
            return value;


            // Confirm that the value can only be retrieved from the process
            //// environment block if running on a Windows system.
            //if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            //{
            //    Console.WriteLine("Attempting to retrieve RUNTIME_ENVIRONMENT from:");
            //    foreach (EnvironmentVariableTarget enumValue in
            //                      Enum.GetValues(typeof(EnvironmentVariableTarget)))
            //    {
            //        value = Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT", enumValue);
            //        Console.WriteLine($"   {enumValue}: {(value != null ? "found" : "not found")}");
            //    }

            //}

            //// If we've created it, now delete it.
            //if (toDelete)
            //{
            //    Environment.SetEnvironmentVariable("RUNTIME_ENVIRONMENT", null);
            //    // Confirm the deletion.
            //    if (Environment.GetEnvironmentVariable("RUNTIME_ENVIRONMENT") == null)
            //        Console.WriteLine("RUNTIME_ENVIRONMENT has been deleted.");
            //}

        }
    }
}
