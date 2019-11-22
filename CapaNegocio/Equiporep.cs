using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            eEquiporep fila = new eEquiporep();

            if (this.ideq != 0)
            {
                var res = from x in dc.eEquiporeps where x.ideq == this.ideq select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else
                    throw new Exception("Id no encontrado en equipo a reparar");
            }


            fila.desc = desc;
            fila.problema = problema;

            if (this.ideq == 0)
                dc.eEquiporeps.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.ideq = fila.ideq;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eEquiporeps where x.ideq == this.ideq select x;
            if (res.Count() > 0)
            {
                dc.eEquiporeps.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Equipo a reparar no encontrado");

        }

        public static List<Equiporep> Buscar(string buscado = "")
        {
            List<Equiporep> Equiposrep= new List<Equiporep>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eEquiporeps
                      where buscado == ""
                      || x.desc.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.problema.ToLower().Trim().Contains(buscado.ToLower().Trim())

                      select x;

            foreach (eEquiporep em in res)
            {
                Equiposrep.Add(new Equiporep(em.ideq, em.desc, em.problema));
            }

            return Equiposrep;
        }

        public override string ToString()
        {
            //return string.Concat(ideq);
            return desc;
        }
    }
}
