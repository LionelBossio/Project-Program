using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public static class Conexion
    {
        private static string server = @"SQLSERVER\SQLSERVE";
        private static string db = @"TallerdeReparacion";
        private static string usuario = @"BDJorge";
        private static string clave = @"123";

        public static string DarConexion()
        {
            return string.Concat(@"Data Source=", server, ";Initial Catalog=", db,
                ";Persist Security Info=False;User ID=", usuario, ";Password=", clave);
        }
    }
}
