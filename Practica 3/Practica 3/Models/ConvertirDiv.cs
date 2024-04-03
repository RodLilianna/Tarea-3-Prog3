namespace Practica_3.Models
{
    public class ConvertirDiv
    {
        private Dictionary<string, double> tasasDeConversion;

        public ConvertirDiv()
        {
            tasasDeConversion = new Dictionary<string, double>();
            tasasDeConversion["USD->EUR"] = 0.94;
            tasasDeConversion["EUR->USD"] = 1.07;
            tasasDeConversion["USD->DOP"] = 56.56;
            tasasDeConversion["DOP->USD"] = 0.018;
            tasasDeConversion["EUR->DOP"] = 60.42;
            tasasDeConversion["DOP->EUR"] = 0.016;
        }

        public double ConvertirDivisa(double cantidad, string de, string a)
        {
            string clave = $"{de.ToUpper()}->{a.ToUpper()}";
            if (tasasDeConversion.ContainsKey(clave))
            {
                double tasa = tasasDeConversion[clave];
                return cantidad * tasa;
            }
            else
            {
                Console.WriteLine("No se encontra una tasa de conversion valida para la combinacion de divisas especificada.");
                return cantidad;
            }
        }
    }
}
