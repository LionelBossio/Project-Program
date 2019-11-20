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
        public Articulo(int idart, string nombre, string desc, int cant)
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
                return new Articulo(x.idart, x.nombre, x.desc, x.cant);
            }
            return null;
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            eArticulo fila = new eArticulo();

            if (this.idart != 0)
            {
                var res = from x in dc.eArticulos where x.idart == this.idart select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else
                    throw new Exception("Id no encontrado en articulo");
            }


            fila.nombre = nombre;
            fila.desc = desc;
            fila.cant = cant;

            if (this.idart == 0)
                dc.eArticulos.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.idart = fila.idart;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eArticulos where x.idart == this.idart select x;
            if (res.Count() > 0)
            {
                dc.eArticulos.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Articulo no encontrado");

        }

        public static List<Articulo> Buscar(string buscado = "")
        {
            List<Articulo> Articulos = new List<Articulo>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eArticulos
                      where buscado == ""
                      || x.nombre.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.desc.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.cant.ToString() == buscado.Trim()
                      select x;

            foreach (eArticulo em in res)
            {
                Articulos.Add(new Articulo(em.idart, em.nombre, em.desc, em.cant));
            }

            return Articulos;
        }
    }
}
