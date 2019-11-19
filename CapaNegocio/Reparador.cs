using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Reparador
    {
        private int idrep;
        private int cantrep;
        private int cantcliente;
        #region Properties
        public int Idrep
        {
            get
            {
                return idrep;
            }

            set
            {
                idrep = value;
            }
        }

        public int Cantrep
        {
            get
            {
                return cantrep;
            }

            set
            {
                cantrep = value;
            }
        }

        public int Cantcliente
        {
            get
            {
                return cantcliente;
            }

            set
            {
                cantcliente = value;
            }
        }
        #endregion
        #region Contructor
        public Reparador()
        {
            idrep = 0;
            cantrep = 0;
            cantcliente = 0;
        }
        public Reparador(int idrep, int cantrep, int cantcliente)
        {
            this.idrep = idrep;
            this.cantrep = cantrep;
            this.cantcliente = cantcliente;
        }
        #endregion
        public static Reparador BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eReparadors
                      where x.idrep == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Reparador(x.idrep, x.cantrep, x.cantcliente);
            }
            return null;
        }
    }
}
