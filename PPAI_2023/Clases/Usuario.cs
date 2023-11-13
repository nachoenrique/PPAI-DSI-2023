using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class Usuario
    {
        private bool activo;
        private DateTime fechaAlta;
        private string nombreUsuario;
        private string password;
        private Perfil perfil;

        public bool Activo { get => activo; set => activo = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        internal Perfil Perfil { get => perfil; set => perfil = value; }

        public void getPerfil() { }
        public void setPerfil() { }
    }
}
