using System.Text.Json;

namespace Practica_3.Models
{
    public class Usuario
    {
        public string Nombusuario { get; set; }
        public string Contrasena { get; set; }
        private List<Usuario> usuarios = new List<Usuario>();
        private Usuario? usuarioActual = null;

        public bool RegistrarUsuario(string Nombusuario, string contrasena)
        {
            if (usuarios.Exists(u => u.Nombusuario == Nombusuario))
            {
                return false;
            }

            var nuevoUsuario = new Usuario { Nombusuario = Nombusuario, Contrasena = contrasena };
            usuarios.Add(nuevoUsuario);
            return true;
        }

        public bool IniciarSesion(string nombusuario, string contrasena)
        {
            usuarioActual = usuarios.Find(u => u.Nombusuario == nombusuario && u.Contrasena == contrasena);
            return usuarioActual != null;
        }

        public bool CerrarSesion()
        {
            usuarioActual = null;
            return true;
        }

        public bool EstaAutenticado()
        {
            return usuarioActual != null;
        }

        public Usuario? ObtenerUsuarioActual()
        {
            return usuarioActual;
        }
    }
}
