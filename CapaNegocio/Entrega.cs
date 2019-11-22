using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.ComponentModel;

namespace CapaNegocio
{
    public class Entrega
    {
        private int ident;
        private bool hecho;
        private string desc;
        private DateTime fecent;
        #region Properties
        [DisplayName("ID")]
        public int Ident
        {
            get
            {
                return ident;
            }

            set
            {
                ident = value;
            }
        }

        public bool Hecho
        {
            get
            {
                return hecho;
            }

            set
            {
                hecho = value;
            }
        }
        [DisplayName("Descripcion")]
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
        [DisplayName("Fecha de entrega")]
        public DateTime Fecent
        {
            get
            {
                return fecent;
            }

            set
            {
                fecent = value;
            }
        }
        #endregion
        #region Constructores
        public Entrega()
        {
            ident = 0;
            hecho = false;
            desc = "";
            fecent = new DateTime();
        }
        public Entrega(int ident, bool hecho, string desc, DateTime fecent)
        {
            this.ident = ident;
            this.hecho = hecho;
            this.desc = desc;
            this.fecent = fecent;
        }
        #endregion
        public static Entrega BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eEntregas
                      where x.ident == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Entrega(x.ident, x.hecho,x.desc, x.fecent);
            }
            return null;
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            eEntrega fila = new eEntrega();

            if (this.ident != 0)
            {
                var res = from x in dc.eEntregas where x.ident == this.ident select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else
                    throw new Exception("Id no encontrado en entrega");
            }


            fila.hecho = hecho;
            fila.desc = desc;
            fila.fecent = fecent;

            if (this.ident == 0)
                dc.eEntregas.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.ident = fila.ident;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eEntregas where x.ident == this.ident select x;
            if (res.Count() > 0)
            {
                dc.eEntregas.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Entrega no encontrada");

        }

        public static List<Entrega> Buscar(string buscado = "")
        {
            List<Entrega> Entregas = new List<Entrega>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eEntregas
                      where buscado == ""
                      || x.hecho.ToString() == buscado.Trim()
                      || x.desc.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.fecent.ToString() == buscado.Trim()
                      select x;

            foreach (eEntrega em in res)
            {
                Entregas.Add(new Entrega(em.ident, em.hecho, em.desc, em.fecent));
            }

            return Entregas;
        }

        public override string ToString()
        {
            return Convert.ToString(ident);
        }
    }
}
