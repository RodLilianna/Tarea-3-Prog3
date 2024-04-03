using Microsoft.AspNetCore.Mvc;
using Practica_3.Models;

[Route("api/operaciones")]
[ApiController]
    public class OperacionesController : ControllerBase
    {
    private Fachada fachada;

    public OperacionesController()
    {
        fachada = new Fachada();
    }

    [HttpGet("Sumar")]
    public ActionResult<double> Sumar(double num1, double num2)
        => (double)fachada.Sumar(num1, num2);
    

    [HttpGet("Dolares_a_pesos")]
    public ActionResult<double> ConvertirDolaresAPesos(double cantidad)
    {
        double resultado = fachada.ConvertirDolaresAPesos(cantidad);
        return resultado;
    }

    [HttpGet("De_Fahrenheit_a_celsius")]
    public ActionResult<double> ConvertirFahrenheitACelsius(double temperatura)
    {
        double resultado = fachada.ConvertirFahrenheitACelsius(temperatura);
        return (Math.Truncate(resultado * 10000 / 10000));
    }



    }

