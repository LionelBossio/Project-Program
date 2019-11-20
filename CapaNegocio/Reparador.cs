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

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            eReparador fila = new eReparador();

            if (this.idrep != 0)
            {
                var res = from x in dc.eReparadors where x.idrep == this.idrep select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else
                    throw new Exception("Id no encontrado en reparador");
            }


            fila.cantrep = cantrep;
            fila.cantcliente = cantcliente;

            if (this.idrep == 0)
                dc.eReparadors.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.idrep = fila.idrep;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eReparadors where x.idrep == this.idrep select x;
            if (res.Count() > 0)
            {
                dc.eReparadors.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Reparador no encontrado");

        }

        public static List<Reparador> Buscar(string buscado = "")
        {
            List<Reparador> Reparadores = new List<Reparador>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eReparadors
                      where buscado == ""
                      || x.cantrep.ToString() == buscado.Trim()
                      || x.cantcliente.ToString() == buscado.Trim()
                      select x;

            foreach (eReparador em in res)
            {
                Reparadores.Add(new Reparador(em.idrep, em.cantrep, em.cantcliente));
            }

            return Reparadores;
        }
    }
}
