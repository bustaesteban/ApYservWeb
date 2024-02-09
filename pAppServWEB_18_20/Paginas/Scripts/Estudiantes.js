jQuery(function () {
    //Registrar los botones para responder al evento click
    $("#dvMenu").load("../Paginas/Menu.html")
    //Registrar los botones para responder al evento click
    $("#btnInsertar").on("click", function () {
        EjecutarComandos("POST");
    });
    $("#btnActualizar").on("click", function () {
        EjecutarComandos("PUT");
    });
    $("#btnEliminar").on("click", function () {
        EjecutarComandos("DELETE");
    });
    $("#btnConsultar").on("click", function () {
        Consultar();
    });
});
async function Consultar() {
    //Capturo los datos de entrada
    let EstudianteID = $("#txtIdentificacionEstudiante").val();
    //Invocamos el servicio a través del fetch, usando el método fetch de javascript
    try {
        const Respuesta = await fetch("http://localhost:53634/api/Estudiantes?EstudianteID=" + EstudianteID,
            {
                method: "GET",
                mode: "cors",
                headers: {
                    "Content-Type": "application/json"
                }
            });
        const Rpta = await Respuesta.json();
        //Se presenta la respuesta en el div mensaje
        $("#txtNombre").val(Rpta.Nombre);
        $("#txtApellido").val(Rpta.Apellido);
        $("#txtEmail").val(Rpta.Email);
        let Fecha = Rpta.FechaNacimiento;
        if (Fecha != undefined) {
            $("#txtFechaNacimiento").val(Fecha.split('T')[0]);
        }
    }
    catch (error) {
        //Se presenta la respuesta en el div mensaje
        $("#dvMensaje").html(error);
    }
}
async function EjecutarComandos(Comando) {
    //Capturo los datos de entrada
    let EstudianteID = $("#txtIdentificacionEstudiante").val();
    let Nombre = $("#txtNombre").val();
    let Apellido = $("#txtApellido").val();
    let Email = $("#txtEmail").val();
    let FechaNacimiento = $("#txtFechaNacimiento").val();
    //Defino el json
    let DatosEstudiante = {
        EstudianteID: EstudianteID,
        Nombre: Nombre,
        Apellido: Apellido,
        Email: Email,
        FechaNacimiento: FechaNacimiento
    }
    //Invocamos el servicio a través del fetch, usando el método fetch de javascript
    try {
        const Respuesta = await fetch("http://localhost:53634/api/Estudiantes",
            {
                method: Comando,
                mode: "cors",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(DatosEstudiante)
            });
        const Rpta = await Respuesta.json();
        //Se presenta la respuesta en el div mensaje
        $("#dvMensaje").html(Rpta);
    }
    catch (error) {
        //Se presenta la respuesta en el div mensaje
        $("#dvMensaje").html(error);
    }
}



