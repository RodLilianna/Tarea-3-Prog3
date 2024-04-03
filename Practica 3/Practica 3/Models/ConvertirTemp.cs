namespace Practica_3.Models
{
    public class ConvertirTemp
    {
        public double ConvertirTemperatura(double cantidad, string de, string a)
        {
            if (de == "Celsius" && a == "Fahrenheit")
            {
                return (cantidad * 9 / 5) + 32;
            }
            else if (de == "Fahrenheit" && a == "Celsius")
            {
                return (cantidad - 32) * 5 / 9;
            }
            else if (de == "Celsius" && a == "Kelvin")
            {
                return cantidad + 273.15;
            }
            else if (de == "Kelvin" && a == "Celsius")
            {
                return cantidad - 273.15;
            }
            else if (de == "Kelvin" && a == "Fahrenheit")
            {
                return (cantidad - 273.15) * 9 / 5 + 32;
            }
            else if (de == "Fahrenheit" && a == "Kelvin")
            {
                return (cantidad - 32) * 5 / 9 + 273.15;
            }

            return cantidad;
        }
    }
}
