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
        private int numtel;
        private string nomusu;
        private string contraseña;
        #region Properties
        [DisplayName("ID")]
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
        [DisplayName("DNI")]
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
        [DisplayName("Fecha de nacimiento")]
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
        [DisplayName("Numero de telefono")]
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
        [DisplayName("Nombre de usuario")]
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
            numtel = 0;
            nomusu = "";
            contraseña = "";
        }
        public Usuario(int idusu, string nombre, string apellido, int dni, DateTime fecnac, string email, int fktipousu, int numtel, string nomusu, string contraseña)
        {
            this.idusu = idusu;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fecnac = fecnac;
            this.email = email;
            this.fktipousu = fktipousu;
            this.tipousu = Tipousu.BuscarPorId(fktipousu);
            this.numtel = numtel;
            this.nomusu = nomusu;
            this.contraseña = contraseña;
        }
        #endregion
        public static Usuario BuscarPorId(int id)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eUsuarios
                      where x.idusu == id
                      select x;
            if (res.Count() > 0)
            {
                var x = res.First();
                return new Usuario(x.idusu, x.nombre, x.apellido, x.dni, x.fecnac, x.email, x.tipousu, x.numtel, x.nomusu, x.contraseña);
            }
            return null;
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            eUsuario fila = new eUsuario();

            if (this.idusu != 0)
            {
                var res = from x in dc.eUsuarios where x.idusu == this.idusu select x;
                if (res.Count() > 0)
                {
                    fila = res.First();
                }
                else
                    throw new Exception("Id no encontrado en usuario");
            }


            fila.nombre = nombre;
            fila.apellido = apellido;
            fila.dni = dni;
            fila.fecnac = fecnac;
            fila.email = email;
            fila.tipousu = fktipousu;
            fila.numtel = numtel;
            fila.nomusu = nomusu;
            fila.contraseña = contraseña;

            if (this.idusu == 0)
                dc.eUsuarios.InsertOnSubmit(fila);

            dc.SubmitChanges();
            this.idusu = fila.idusu;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eUsuarios where x.idusu == this.idusu select x;
            if (res.Count() > 0)
            {
                dc.eUsuarios.DeleteOnSubmit(res.First());
                dc.SubmitChanges();
            }
            else
                throw new Exception("Usuario no encontrado");

        }

        public static List<Usuario> Buscar(string buscado = "")
        {
            List<Usuario> Usuarios = new List<Usuario>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eUsuarios
                      where buscado == ""
                      || x.nombre.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.apellido.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.dni.ToString() == buscado.Trim()
                      || x.fecnac.ToString() == buscado.Trim()
                      || x.email.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.tipousu.ToString() == buscado.Trim()
                      || x.numtel.ToString() == buscado.Trim()
                      || x.nomusu.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      || x.contraseña.ToLower().Trim().Contains(buscado.ToLower().Trim())
                      select x;

            foreach (eUsuario em in res)
            {
                Usuarios.Add(new Usuario(em.idusu, em.nombre, em.apellido, em.dni, em.fecnac, em.email, em.tipousu, em.numtel, em.nomusu, em.contraseña));
            }

            return Usuarios;
        }

        public bool Verificar(string nomusu, int dni)
        {
            List<Usuario> Usuarios = new List<Usuario>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eUsuarios
                      where x.nomusu.ToLower().Trim().Contains(nomusu.ToLower().Trim())
                      || x.dni==dni
                      select x;

            if (res == null || res.Count() == 0)
            {
                bool verificado = true;
                return verificado;
            }
            else
            {
                bool verificado = false;
                return verificado;
            }

        }

        public bool VerificarMod(string nomusu,int id,int dni)
        {
            List<Usuario> Usuarios = new List<Usuario>();
            DCDataContext dc = new DCDataContext(Conexion.DarConexion());
            var res = from x in dc.eUsuarios
                      where (x.nomusu.ToLower().Trim().Contains(nomusu.ToLower().Trim())
                      || x.dni == dni)
                      && x.idusu != id
                      select x;

            if (res == null || res.Count() == 0)
            {
                bool verificado = true;
                return verificado;
            }
            else
            {
                bool verificado = false;
                return verificado;
            }

        }
        
        public override string ToString()
        {
            return nomusu;
        }
    }
}
