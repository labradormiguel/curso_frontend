$(document).ready(function () {

    $("#formulario").hide();
    $("#botonCancelar").hide();

    $.getJSON("/Home/ListaClientesJSON", function (datos) {
        for (let i = 0; i < datos.length; i++) {

            $("#mitabla").append(
                `<tr>
                    <td>${datos[i].dni}</td>
                    <td>${datos[i].nombre}</td>
                    <td>${datos[i].apellido}</td>
                    <td style="justify-content: center;">
                        <input type="checkbox" name="check" id="check">
                    </td>
                </tr>`
            )

        }
    })

    $("#nombre").focus();

    /*     $("#nombre").keyup(function () {
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
        }) */

    $("#botonInsertar").click(function () {

        if ($(this).text() === "Insertar") {

            // Botón de Insertar

            $("#mitabla").append(
                `<tr>
                    <td>
                        <input type='text' name='dni' id='insName' class='ins'
                         placeholder='11111111-X'/>
                    </td>
                    <td>
                        <input type='text' name='nombre' class='ins'
                         placeholder='Introduce nombre' />
                    </td>
                    <td><input type='text' name='apellido' class='ins'
                     placeholder='Introduce apellido' />
                    </td>
                    <td>
                        <input type='checkbox' name='check' class='check' />
                    </td>
                </tr>`
            )
            $("#mitabla").prepend("<form action='/Home/Insertar'>");
            $("#formulario").append("</form>");
            $("#nombre").prop("disabled", true);
            $("#insName").focus();
            $(this).text("Confirmar");
            $("#botonEditar").hide();
            $("#botonBorrar").hide();
            $("#botonCancelar").show();

        } else {

            // Botón de Confirmar

            $("#nombre").prop("disabled", false);
            $(this).text("Insertar");
            $("#botonCancelar").hide();
            $("#botonEditar").show();
            $("#botonBorrar").show();
            $("#nombre").focus();
        }
    });

    $("#botonCancelar").click(function () {

        $("#mitabla tr:last").remove();
        $("#nombre").prop("disabled", false);
        $("#botonInsertar").text("Insertar");
        $(this).hide();
        $("#botonEditar").show();
        $("#botonBorrar").show();
        $("#nombre").focus();

    });

    $("#insertarForm").click(function () {
        $("#listado").hide();
        $("#formulario").show();
    })

    $("#buttonIns").click(function () {
        var cliente = {};
        cliente.dni = $("#dniIns").val();
        cliente.nombre = $("#nombreIns").val();
        cliente.apellido = $("#apellidoIns").val();
        console.log(cliente);

        $.ajax({
            url: "/home/insertarjson",
            type: "POST",
            data: JSON.stringify(cliente),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            error: function (response) {
                alert(response.responseText);
            },
            success: function (response) {
                $("#listado").show();
                $("#formulario").hide();
                $("#mitabla").empty()
                buscarTodos();
            }
        })

    })





});

function buscarTodos() {
    $.getJSON("/home/listaclientesjson", function (datos) {
        for (let i = 0; i < datos.length; i++) {
            $("#mitabla").append(`<tr>
                                            <td>${datos[i].dni}</td>
                                            <td>${datos[i].nombre}</td>
                                            <td>${datos[i].apellido}</td>
                                            <td style="justify-content: center;">
                        <input type="checkbox" name="check" id="check">
                    </td>

                                            </tr>`);
        }
    })
}