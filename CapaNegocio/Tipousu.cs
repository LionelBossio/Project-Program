using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Tipousu
    {
        private int idtiu;
        private string tipodeusu;
        private string desc;
        #region Properties
        public int Idtiu
        {
            get
            {
                return idtiu;
            }

            set
            {
                idtiu = value;
            }
        }

        public string Tipodeusu
        {
            get
            {
                return tipodeusu;
            }

            set
            {
                tipodeusu = value;
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
        #endregion
        #region Constructor
        public Tipousu()
        {
            idtiu = 0;
            tipodeusu = "";
            desc = "";
        }
        public Tipousu(int idtiu,string tipodeusu, string desc)
        {
            this.idtiu = idtiu;
            this.tipodeusu = tipodeusu;
            this.desc = desc;
        }
        #endregion
        public static Tipousu BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eTipousus
                      where x.idtiu == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Tipousu(x.idtiu, x.tipodeusu, x.desc);
            }
            return null;
        }
    }
}
