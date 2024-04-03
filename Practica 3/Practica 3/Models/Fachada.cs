namespace Practica_3.Models
{
    public class Fachada
    {
        private ConvertirTemp temp = new ConvertirTemp();
        private ConvertirDiv div = new ConvertirDiv();
        private OpAritmeticas op = new OpAritmeticas();

        public double ConvertirDolaresAPesos(double cantidad)
        {
            return div.ConvertirDivisa(cantidad, "USD", "DOP");
        }

        public double Sumar(double num1, double num2)
        {
            return op.Sumar(num1, num2);
        }

        public double ConvertirFahrenheitACelsius(double temperatura)
        {
            return temp.ConvertirTemperatura(temperatura, "Fahrenheit", "Celsius");
        }
    }
}
