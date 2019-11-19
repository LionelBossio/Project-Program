using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public static class Conexion
    {
        public static string DarConexion()
        {
            return CapaDatos.Conexion.DarConexion();
        }
    }
}
