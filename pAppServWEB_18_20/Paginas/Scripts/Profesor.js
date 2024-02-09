var oTablaProfesores = $("#tblProfesores").DataTable();

$(document).ready(function () {
    $("#tblProfesores tbody").on("click", 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        } else {
            oTablaProfesores.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
            EditarFilaProfesor($(this).closest('tr'));
        }
    });
    //Registrar los botones para responder al evento click
    $("#dvMenu").load("../Paginas/Menu.html")
    $("#btnInsertarProfesor").on("click", function () {
        EjecutarComandosProfesor("POST");
    });

    $("#btnActualizarProfesor").on("click", function () {
        EjecutarComandosProfesor("PUT");
    });

    $("#btnEliminarProfesor").on("click", function () {
        EjecutarComandosProfesor("DELETE");
    });

    LlenarTablaProfesores();
});

function EditarFilaProfesor(DatosFila) {
    $("#txtCodigoProfesor").val(DatosFila.find('td:eq(0)').text());
    $("#txtNombreProfesor").val(DatosFila.find('td:eq(1)').text());
    $("#txtApellidoProfesor").val(DatosFila.find('td:eq(2)').text());
    $("#txtEmailProfesor").val(DatosFila.find('td:eq(3)').text());
    let activo = DatosFila.find('td:eq(4)').text();
    if (activo == 'true') {
        $("#chkActivo").prop('checked', true);
    }
    else {
        $("#chkActivo").prop('checked', false);
    }
}

function LlenarTablaProfesores() {
    LlenarTablasXServicio("http://localhost:53634/api/Profesor", "#tblProfesores");
}

async function EjecutarComandosProfesor(Comando) {
    let Codigo = $("#txtCodigoProfesor").val();
    let Nombre = $("#txtNombreProfesor").val();
    let Apellido = $("#txtApellidoProfesor").val();
    let Email = $("#txtEmailProfesor").val();
    let Activo = $("#chkActivo").prop('checked');

    let DatosProfesor = {
        ProfesorID: Codigo,
        Nombre: Nombre,
        Apellido: Apellido,
        Email: Email,
        Activo: Activo
    }

    try {
        const Respuesta = await fetch("http://localhost:53634/api/Profesor",
            {
                method: Comando,
                mode: "cors",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(DatosProfesor)
            });
        const Rpta = await Respuesta.json();
        $("#dvMensajeProfesor").html(Rpta);
        LlenarTablaProfesores();
    }
    catch (error) {
        $("#dvMensajeProfesor").html(error);
    }
}
