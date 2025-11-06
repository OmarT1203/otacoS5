using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace otacoS5.Clases
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            //Se define la ruta y el nombre a la base de datos (Archivo)
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);
        }
    }
}
