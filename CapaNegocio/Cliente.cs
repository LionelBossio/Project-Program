using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente
    {
        private int idcli;
        private int codigocli;
        private string nombre;
        private int telefono;
        private int fkequiporep;
        private Equiporep equiporep;
        #region Properties
        public int Idcli
        {
            get
            {
                return idcli;
            }

            set
            {
                idcli = value;
            }
        }

        public int Codigocli
        {
            get
            {
                return codigocli;
            }

            set
            {
                codigocli = value;
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

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        [Browsable(false)]
        public int Fkequiporep
        {
            get
            {
                return fkequiporep;
            }

            set
            {
                fkequiporep = value;
            }
        }

        public Equiporep Equiporep
        {
            get
            {
                return equiporep;
            }

            set
            {
                equiporep = value;
                Fkequiporep = value.Ideq;
            }
        }
        #endregion
        #region Constructor
        public Cliente()
        {
            idcli = 0;
            codigocli = 0;
            nombre = "";
            telefono = 0;
            fkequiporep = 0;
        }
        public Cliente(int idcli,int codigocli, string nombre, int telefono,int fkequiporep)
        {
            this.idcli = idcli;
            this.codigocli = codigocli;
            this.nombre = nombre;
            this.telefono = telefono;
            this.fkequiporep = fkequiporep;
            this.equiporep = Equiporep.BuscarPorId(fkequiporep);
        }
        #endregion
        public static Cliente BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eClientes
                      where x.idcli == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Cliente(x.idcli, x.codigocli, x.nombre, x.telefono,x.equiporep);
            }
            return null;
        }
    }
}
