using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Articulo
    {
        private int idart;
        private string nombre;
        private string desc;
        private int cant;
        #region Properties
        public int Idart
        {
            get
            {
                return idart;
            }

            set
            {
                idart = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Desc
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
            }
        }

        public int Cant
        {
            get
            {
                return cant;
            }

            set
            {
                cant = value;
            }
        }
        #endregion
        #region Contructores
        public Articulo()
        {
            idart = 0;
            nombre = "";
            desc = "";
            cant = 0;
        }
        public Articulo(int idart,string nombre, string desc, int cant)
        {
            this.idart = idart;
            this.nombre = nombre;
            this.desc = desc;
            this.cant = cant;
        }
        #endregion
        public static Articulo BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eArticulos
                      where x.idart == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Articulo(x.idart, x.nombre, x.desc,x.cant);
            }
            return null;
        }
    }
}
