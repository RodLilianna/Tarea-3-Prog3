

function sumar() {
    
    var num1 = parseFloat(document.getElementById("numero1").value);
    var num2 = parseFloat(document.getElementById("numero2").value);

    fetch("https://localhost:7127/api/operaciones/Sumar?num1=" + num1 + "&num2=" + num2)
        .then(response => response.json())
        .then(data => {
            document.getElementById("ResultadoSuma").textContent = data;
        })
        .catch(error => {
            console.error("Error:", error);
        });
}

function convertirDolaresAPesos() {

    var cantidadDolares = parseFloat(document.getElementById("CantidadDolares").value);

    fetch("https://localhost:7127/api/operaciones/Dolares_a_pesos?cantidad=" + cantidadDolares)
        .then(response => response.json())
        .then(data => {
            document.getElementById("ResultadoDolaresAPesos").textContent = data;
        })
        .catch(error => {
            console.error("Error:", error);
        });
}

function convertirFahrenheitACelsius() {

    var temperaturaFahrenheit = parseFloat(document.getElementById("TempFahrenheit").value);

    fetch("https://localhost:7127/api/operaciones/De_Fahrenheit_a_celsius?temperatura=" + temperaturaFahrenheit)
        .then(response => response.json())
        .then(data => {
            document.getElementById("ResultadoFahrenheitACelsius").textContent = data;
        })
        .catch(error => {
            console.error("Error:", error);
        });
}