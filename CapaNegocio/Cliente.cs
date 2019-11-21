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
        private string nombre;
        private int telefono;
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
        #endregion
        #region Constructor
        public Cliente()
        {
            idcli = 0;
            nombre = "";
            telefono = 0;

        }
        public Cliente(int idcli ,string nombre, int telefono)
        {
            this.idcli = idcli;
            this.nombre = nombre;
            this.telefono = telefono;
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
                return new Cliente(x.idcli,x.nombre,x.telefono);
            }
            return null;
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            eCliente fila = new eCliente();

            if (this.idcli != 0)
            {
                var res = from x in dc.eClientes where x.idcli == this.idcli select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else
                    throw new Exception("Id no encontrado en clientes");
            }


           
            fila.nombre = nombre;
            fila.telefono = telefono;
          
            if (this.idcli == 0)
                dc.eClientes.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.idcli = fila.idcli;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eClientes where x.idcli == this.idcli select x;
            if (res.Count() > 0)
            {
                dc.eClientes.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Cliente no encontrado");

        }

        public static List<Cliente> Buscar(string buscado = "")
        {
            List<Cliente> Clientes = new List<Cliente>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eClientes
                      where buscado == ""
                      || x.nombre.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.telefono.ToString() == buscado.Trim()
                      select x;

            foreach (eCliente em in res)
            {
                Clientes.Add(new Cliente(em.idcli, em.nombre, em.telefono));
            }

            return Clientes;
        }
    }
}
