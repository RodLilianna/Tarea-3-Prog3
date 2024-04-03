$(document).ready(() => {
    console.log('ready');
});


function registrarUsuario() {
    const nombusuario = document.getElementById("nombusuario").value;
    const contrasena = document.getElementById("contrasena").value;

    if (nombusuario === "" || contrasena === "") {
        swal("Campos Vacíos", "Por favor, complete todos los campos.", "error");
        return;
    }

    fetch("https://localhost:7127/api/LogIn/Registro?Nombusuario=" + nombusuario + "&Contrasena=" + contrasena)
        .then(response => response.json())
        .then(data => {
            // console.log(data)
            // enviar al usuario al dasbor
            if (data == true) {
                console.log('registrado');
                document.getElementById("nombusuario").value = "";
                document.getElementById("contrasena").value = "";
                swal("Registro Exitoso", "Intente iniciar seccion!", "success");
                // window.location.href = 'index.html';
            } else {
                swal("Credenciales no validas", "Intente de nuevo!", "error")
            }
        })



    // fetch("https://localhost:7127/api/LogIn/Registro", {
    //     method: "POST",
    //     headers: {
    //         "Content-Type": "application/json",
    //     },
    //     body: JSON.stringify({
    //         Nombusuario: nombusuario,
    //         Contrasena: contrasena,
    //     }),
    // })
    //     .then(response => response.text())
    //     .then(data => {
    //         console.log("Registro exitoso: " + data);

    //         document.getElementById("nombusuario").value = "";
    //         document.getElementById("contrasena").value = "";
    //         swal("Registro Exitoso", "Intente iniciar seccion!", "success");
    //     })
    //     .catch(error => {
    //         swal("Campos no completados correctamente", "Intente de nuevo!", "error");
    //     });
}

function iniciarSesion() {
    const nombusuario = document.getElementById("nombusuario").value;
    const contrasena = document.getElementById("contrasena").value;

    if (nombusuario === "" || contrasena === "") {
        swal("Campos Vacíos", "Por favor, complete todos los campos.", "error");
        return;
    }
    fetch("https://localhost:7127/api/LogIn/InicioSesion?Nombusuario=" + nombusuario + "&Contrasena=" + contrasena)
        .then(response => response.json())
        .then(data => {
            // console.log(data)
            // enviar al usuario al dasbor
            if (data == true) {
                console.log('funciona');
                window.location.href = 'index.html';
            } else {
                swal("Credenciales no validas", "Intente de nuevo!", "error")
            }
        })
}

function cerrarSesion() {
    fetch("https://localhost:7127/api/LogIn/Cerrar-sesion", {
        method: "POST"
    })
        .then(response => response.text())
        .then(data => {
            console.log("Cierre de sesión: " + data);
        })
        .catch(error => {
            console.error("Error:", error);
        });
}

function estaAutenticado() {
    fetch("https://localhost:7127/api/LogIn/Autenticado")
        .then(response => response.json())
        .then(data => {
            console.log("Usuario autenticado: " + data);
        })
        .catch(error => {
            console.error("Error:", error);
        });
}

function obtenerRegistros() {
    fetch("https://localhost:7127/api/LogIn/Registros")
        .then(response => response.json())
        .then(data => {
            console.log("Registros: " + data);
        })
        .catch(error => {
            console.error("Error:", error);
        });
}


/*let user = document.querySelector('#user');
let pass = document.querySelector('#password');

function enviar() {
    fetch("https://localhost:7127/api/operaciones/Sumar?num1=" + num1 + "&num2=" + num2)
        .then(response => response.json())
        .then(data => {
            // enviar al usuario al dasbor
            if (data == true) {
                console.log('funciona');
                window.location.href = 'index.html';
            } else {
                swal("Credenciales no validas", "Intente de nuevo!", "error")
            }
        })

}*/
