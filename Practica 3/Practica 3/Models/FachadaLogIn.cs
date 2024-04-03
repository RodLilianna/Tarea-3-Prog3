using System.Text.Json;

namespace Practica_3.Models
{
    public class FachadaLogIn
    {
        private Log Log { get; }
        private Usuario Usuario { get; }
        private string archivoLog = "LOG.TXT";
        public FachadaLogIn()
        {
            Log = Log.Instancia;
            Usuario = new Usuario();
        }

        public bool RegistrarUsuario(string nombusuario, string contrasena)
        {
            string registro = $"{nombusuario}|{contrasena}|";
            try
            {
                File.AppendAllText(archivoLog, registro + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de registro: {ex.Message}");
                return false;
            }

        }

        public bool IniciarSesion(string nombusuario, string contrasena)
        {

            var filename = "LOG.txt";
            var lines = File.ReadAllLines(filename);

            var model = lines.Select(p => new
            {
                Nombusuario = p.Split("|")[0],
                Contrasena = p.Split("|")[1]
            });


            var json = JsonSerializer.Serialize(model);
            var user = JsonSerializer.Deserialize<List<Usuario>>(json);
            var u = user.Find(u => u.Nombusuario == nombusuario && u.Contrasena == contrasena);
            return (u != null) ? true : false;
        }

        public bool CerrarSesion()
        {
            var usuarioActual = Usuario.ObtenerUsuarioActual();
            if (usuarioActual != null)
            {
                Log.RegistrarOperacion(usuarioActual.Nombusuario, "Cierre de sesión", usuarioActual.Nombusuario, "Éxito");
                Usuario.CerrarSesion();
                return true;
            }
            return false;
        }

        public bool EstaAutenticado()
        {
            return Usuario.EstaAutenticado();
        }

        public List<string> ObtenerRegistros()
        {
            return Log.ObtenerRegistros();
        }
    }
}
