using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Entrega
    {
        private int ident;
        private bool hecho;
        private string desc;
        private DateTime fecent;
        #region Properties
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
    }
}
