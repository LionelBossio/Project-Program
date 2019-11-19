using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Equiporep
    {
        private int ideq;
        private string desc;
        private string problema;
        #region Properties
        public int Ideq
        {
            get
            {
                return ideq;
            }

            set
            {
                ideq = value;
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

        public string Problema
        {
            get
            {
                return problema;
            }

            set
            {
                problema = value;
            }
        }
        #endregion
        #region Constructor
        public Equiporep()
        {
            ideq = 0;
            desc = "";
            problema = "";
        }
        public Equiporep(int ideq, string desc, string problema)
        {
            this.ideq = ideq;
            this.desc = desc;
            this.problema = problema;
        }
        #endregion
        public static Equiporep BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eEquiporeps
                      where x.ideq == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Equiporep(x.ideq, x.desc, x.problema);
            }
            return null;
        }
    }
}
