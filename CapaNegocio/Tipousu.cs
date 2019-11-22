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

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            eTipousu fila = new eTipousu();

            if (this.idtiu!= 0)
            {
                var res = from x in dc.eTipousus where x.idtiu == this.idtiu select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else
                    throw new Exception("Id no encontrado en tipo de usuario");
            }


            fila.tipodeusu = tipodeusu;
            fila.desc = desc;

            if (this.idtiu == 0)
                dc.eTipousus.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.idtiu = fila.idtiu;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eTipousus where x.idtiu == this.idtiu select x;
            if (res.Count() > 0)
            {
                dc.eTipousus.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Tipo de usuario no encontrado");

        }

        public static List<Tipousu> Buscar(string buscado = "")
        {
            List<Tipousu> Tipodeusus = new List<Tipousu>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eTipousus
                      where buscado == ""
                      || x.tipodeusu.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.desc.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      select x;

            foreach (eTipousu em in res)
            {
                Tipodeusus.Add(new Tipousu(em.idtiu, em.tipodeusu, em.desc));
            }

            return Tipodeusus;
        }

        public override string ToString()
        {
            //return string.Concat(ideq);
            return tipodeusu;
        }
    }
}
