using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Reparacion
    {
        private int idr;
        private DateTime fecini;
        private int fkentrega;
        private Entrega entrega;
        private int fkcliente;
        private Cliente cliente;
        private int fkequiporep;
        private Equiporep equiporep;
        private int fkreparador;
        private Reparador reparador;
        private int fkarticulo;
        private Articulo articulo;
        #region Properties
        public int Idr
        {
            get
            {
                return idr;
            }

            set
            {
                idr = value;
            }
        }

        public DateTime Fecini
        {
            get
            {
                return fecini;
            }

            set
            {
                fecini = value;
            }
        }

        [Browsable(false)]
        public int Fkentrega
        {
            get
            {
                return fkentrega;
            }

            set
            {
                fkentrega = value;
            }
        }

        public Entrega Entrega
        {
            get
            {
                return entrega;
            }

            set
            {
                entrega = value;
                Fkentrega = value.Ident;
            }
        }

        [Browsable(false)]
        public int Fkcliente
        {
            get
            {
                return fkcliente;
            }

            set
            {
                fkcliente = value;
            }
        }

        internal Cliente Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
                Fkcliente = value.Idcli;
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

        [Browsable(false)]
        public int Fkreparador
        {
            get
            {
                return fkreparador;
            }

            set
            {
                fkreparador = value;
            }
        }

        public Reparador Reparador
        {
            get
            {
                return reparador;
            }

            set
            {
                reparador = value;
                Fkreparador = value.Idrep;
            }
        }

        [Browsable(false)]
        public int Fkarticulo
        {
            get
            {
                return fkarticulo;
            }

            set
            {
                fkarticulo = value;
            }
        }

        public Articulo Articulo
        {
            get
            {
                return articulo;
            }

            set
            {
                articulo = value;
                Fkarticulo = value.Idart;
            }
        }
        #endregion
        #region Constructores
        public Reparacion()
        {
            idr = 0;
            fecini = new DateTime();
            fkentrega = 0;
            fkcliente = 0;
            fkequiporep = 0;
            fkreparador = 0;
            fkarticulo = 0;
        }
        public Reparacion(int idr,DateTime fecini,int fkentrega,int fkcliente,int fkequiporep, int fkreparador, int fkarticulo)
        {
            this.idr = idr;
            this.fecini = fecini;
            this.fkentrega = fkentrega;
            this.entrega = Entrega.BuscarPorId(fkentrega);
            this.fkcliente = fkcliente;
            this.cliente = Cliente.BuscarPorId(fkcliente);
            this.fkequiporep = fkequiporep;
            this.equiporep = Equiporep.BuscarPorId(fkequiporep);
            this.fkreparador = fkreparador;
            this.reparador = Reparador.BuscarPorId(fkreparador);
            this.fkarticulo = fkarticulo;
            this.articulo = Articulo.BuscarPorId(fkarticulo);
        }
        #endregion
        public static Reparacion BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eReparacions
                      where x.idr == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Reparacion(x.idr, x.fecini, x.entrega, x.cliente, x.equiporep, x.reparador, x.articulo);
            }
            return null;
        }
    }
}
