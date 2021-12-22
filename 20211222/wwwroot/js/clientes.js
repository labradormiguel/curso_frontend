$(document).ready(function () {

    $("#nombre").focus();

    $("#nombre").keyup(function () {
        console.log($(this).val());

        $.getJSON("/home/ListaClientesJSON?nombre=" +
            $(this).val(), function (datos) {
                console.log(datos);
                $("#mitabla").empty();
                $("#mitabla").append(
                    "<tr><th>DNI</th><th>Nombre</th><th>Apellido</th><th><input type='checkbox' name='masscheck' class='masscheck' /></th></tr>"
                )
                for (let i = 0; i < datos.length; i++) {
                    $("#mitabla").append("<tr><td>" + datos[i].dni
                        + "</td><td>" + datos[i].nombre + "</td><td>" +
                        datos[i].apellido + "</td><td><input type='checkbox' name='check' class='check' /></td></tr>");
                }
            })
    })

    $("#botonInsertar").click(function () {

        if ($(this).text() === "Insertar") {

            // Botón de Insertar

            $("#mitabla").append(
                "<tr><td><input type='text' name='dni' id='insName' class='ins' placeholder='11111111-X'/></td><td><input type='text' name='nombre' class='ins' placeholder='Introduce nombre' /></td><td><input type='text' name='apellido' class='ins' placeholder='Introduce apellido' /></td><td><input type='checkbox' name='check' class='check' /></td></tr>"
            )
            $("#mitabla").prepend("<form action='/Home/Insertar'>");
            $("#formulario").append("</form>");
            $("#nombre").prop("disabled", true);
            $("#insName").focus();
            $(this).text("Confirmar");
            $("#botonEditar").css('visibility', 'hidden');
            $("#botonBorrar").css('visibility', 'hidden');
            $("#botonCancelar").css('visibility', 'visible');

        } else {

            // Botón de Confirmar

            $("#nombre").prop("disabled", false);
            $(this).text("Insertar");
            $("#botonCancelar").css('visibility', 'hidden');
            $("#botonEditar").css('visibility', 'visible');
            $("#botonBorrar").css('visibility', 'visible');
            $("#nombre").focus();
        }
    });

    $("#botonCancelar").click(function () {

        $("#mitabla tr:last").remove();
        $("#nombre").prop("disabled", false);
        $("#botonInsertar").text("Insertar");
        $(this).css('visibility', 'hidden');
        $("#botonEditar").css('visibility', 'visible');
        $("#botonBorrar").css('visibility', 'visible');
        $("#nombre").focus();

    });
})