var oTablaCursos = $("#tblCursos").DataTable();

$(document).ready(function () {
    $("#tblCursos tbody").on("click", 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        } else {
            oTablaCursos.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
            EditarFilaCurso($(this).closest('tr'));
        }
    });
    //Registrar los botones para responder al evento click
    $("#dvMenu").load("../Paginas/Menu.html")

    $("#btnInsertarCurso").on("click", function () {
        EjecutarComandosCurso("POST");
    });

    $("#btnActualizarCurso").on("click", function () {
        EjecutarComandosCurso("PUT");
    });

    $("#btnEliminarCurso").on("click", function () {
        EjecutarComandosCurso("DELETE");
    });

    LlenarComboProfesores();
    LlenarTablaCursos();
});

function EditarFilaCurso(DatosFila) {
    $("#txtCodigoCurso").val(DatosFila.find('td:eq(1)').text());
    $("#txtNombreCurso").val(DatosFila.find('td:eq(2)').text());
    $("#txtDescripcion").val(DatosFila.find('td:eq(3)').text());
    let activo = DatosFila.find('td:eq(5)').text();
    if (activo == 'true') {
        $("#chkActivo").prop('checked', true);
    }
    else {
        $("#chkActivo").prop('checked', false);
    }
    // Obtener el ID del profesor seleccionado
    let idProfesor = DatosFila.find('td:eq(0)').text();

    // Seleccionar el profesor en el combo por su ID
    $("#cboProfesor").val(idProfesor);
}

function LlenarComboProfesores() {
    fetch("http://localhost:53634/api/Profesor")
        .then(response => response.json())
        .then(data => {
            data.forEach(profesor => {
                $("#cboProfesor").append(`<option value="${profesor.ProfesorID}">${profesor.Nombre}</option>`);
            });
        })
        .catch(error => console.error('Error:', error));
}

function LlenarTablaCursos() {
    LlenarTablasXServicio("http://localhost:53634/api/Curso", "#tblCursos");
}

async function EjecutarComandosCurso(Comando) {
    let Codigo = $("#txtCodigoCurso").val();
    let Nombre = $("#txtNombreCurso").val();
    let Descripcion = $("#txtDescripcion").val();
    let Activo = $("#chkActivo").prop('checked');
    let ProfesorID = $("#cboProfesor").val();
    let DatosCurso = {
        CursoID: Codigo,
        NombreCurso: Nombre,
        Descripcion: Descripcion,
        Activo: Activo,
        ProfesorID: ProfesorID
    }

    try {
        const Respuesta = await fetch("http://localhost:53634/api/Curso",
            {
                method: Comando,
                mode: "cors",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(DatosCurso)
            });
        const Rpta = await Respuesta.json();
        $("#dvMensajeCurso").html(Rpta);
        LlenarTablaCursos();
    }
    catch (error) {
        $("#dvMensajeCurso").html(error);
    }
}
