using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class Usuario
    {
        private int idusu;
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime fecnac;
        private string email;
        private int fktipousu;
        private Tipousu tipousu;
        private int fkrepde;
        private Reparacion repde;
        private int numtel;
        private string nomusu;
        private string contraseña;
        #region Properties
        public int Idusu
        {
            get
            {
                return idusu;
            }

            set
            {
                idusu = value;
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

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public DateTime Fecnac
        {
            get
            {
                return fecnac;
            }

            set
            {
                fecnac = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        [Browsable(false)]
        public int Fktipousu
        {
            get
            {
                return fktipousu;
            }

            set
            {
                fktipousu = value;
            }
        }

        public Tipousu Tipousu
        {
            get
            {
                return tipousu;
            }

            set
            {
                tipousu = value;
                Fktipousu = value.Idtiu;
            }
        }

        [Browsable(false)]
        public int Fkrepde
        {
            get
            {
                return fkrepde;
            }

            set
            {
                fkrepde = value;
            }
        }

        public Reparacion Repde
        {
            get
            {
                return repde;
            }

            set
            {
                repde = value;
                Fkrepde = value.Idr;
            }
        }

        public int Numtel
        {
            get
            {
                return numtel;
            }

            set
            {
                numtel = value;
            }
        }

        public string Nomusu
        {
            get
            {
                return nomusu;
            }

            set
            {
                nomusu = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }
        #endregion
        #region Constructor
        public Usuario()
        {
            idusu = 0;
            nombre = "";
            apellido = "";
            dni = 0;
            fecnac = new DateTime();
            email = "";
            fktipousu = 0;
            fkrepde = 0;
            numtel = 0;
            nomusu = "";
            contraseña = "";
        }
        public Usuario(int idusu, string nombre, string apellido,int dni,DateTime fecnac, string email, int fktipousu, int fkrepde,int numtel, string nomusu, string contraseña)
        {
            this.idusu = idusu;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fecnac = fecnac;
            this.email = email;
            this.fktipousu = fktipousu;
            this.tipousu = Tipousu.BuscarPorId(fktipousu);
            this.fkrepde = fkrepde;
            this.repde = Reparacion.BuscarPorId(fkrepde);
            this.numtel = numtel;
            this.nomusu = nomusu;
            this.contraseña = contraseña;
        }
        #endregion
    }
}
