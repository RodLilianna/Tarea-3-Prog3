namespace Practica_3.Models
{
    public class Log
    {
        private static Log instancia = null;
        private List<string> registros = new List<string>();
        private string archivoLog = "LOG.TXT";

        private Log() { }

        public static Log Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Log();
                }
                return instancia;
            }
        }

        public void RegistrarOperacion(string usuario, string operacion, string entrada, string salida)
        {
            string registro = $"{usuario}|Usuario: {usuario}|Operación: {operacion}|Entrada: {entrada}|Salida: {salida}";
            registros.Add(registro);

            try
            {
                File.AppendAllText(archivoLog, registro + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de registro: {ex.Message}");
            }
        }

        public List<string> ObtenerRegistros()
        {
            return registros;
        }
    }
}
