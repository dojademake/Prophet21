using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace P21Custom.Rules.Visual.Utilities
{
    public class FileUtility
    {
        public static string ReadFileFromAppData(string fileName)
        {
            // Get the server-side path of the App_Data folder
            string appDataPath = HttpContext.Current.Server.MapPath("~/App_Data");

            // Combine the folder path and the file name to get the full path
            string fullPath = Path.Combine(appDataPath, fileName);

            try
            {
                // Read the content of the file
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
