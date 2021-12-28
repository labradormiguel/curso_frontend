$(document).ready(function () {

    $("#formulario").hide();
    $("#botonCancelar").hide();

    buscarTodos();

    $("#nombre").focus();

    $("#nombre").keyup(function () {

        $.getJSON("/home/ListaClientesJSON?nombre=" +
            $(this).val(), function (datos) {

                $("#mitabla").empty();
                $("#mitabla").append(
                    `<tr>
                        <th>DNI</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th>
                            Borrar
                        </th>
                        <th>
                            Editar
                        </th>
                    </tr>`);

                for (let i = 0; i < datos.length; i++) {

                    $("#mitabla").append(
                        `<tr>
                                <td>${datos[i].dni}</td>
                                <td>${datos[i].nombre}</td>
                                <td>${datos[i].apellido}</td>
                                <td>
                                    <a href="" onclick="borrar('/${datos[i].dni}');
                                    return false;">❌</a>
                                </td>
                                <td>
                                    📂
                                </td>
                            </tr>`);
                }
            })
    });

    $("#botonInsertar").click(function () {
        
//        console.log("<"+$(this).text()+">");
  //      console.log("<"+$(this).html()+">");
        console.log($(this).attr("value"));

        if ($(this).attr("value") === "Insertar") {

            // Botón de Insertar

            $("#mitabla").append(
                `<tr>
                    <td>
                        <input type='text' name='dni' id='insDni' class='ins'
                         placeholder='11111111-X'/>
                    </td>
                    <td>
                        <input type='text' name='nombre' class='ins'
                         id="insNombre" placeholder='Introduce nombre' />
                    </td>
                    <td><input type='text' name='apellido' class='ins'
                     id="insApellido" placeholder='Introduce apellido' />
                    </td>
                    <td>
                        ❌
                    </td>
                    <td>
                        📂
                    </td>
                </tr>`
            )

            $("#nombre").prop("disabled", true);
            $("#insDni").focus();
            $(this).attr("value", "Confirmar");
            $("#botonEditar").hide();
            $("#botonBorrar").hide();
            $("#botonCancelar").show();

        } else {

            // Botón de Confirmar

            insertar();
            $("#nombre").prop("disabled", false);
            $(this).attr("value", "Insertar");
            $("#botonCancelar").hide();
            $("#botonEditar").show();
            $("#botonBorrar").show();
            $("#nombre").focus();
            buscarTodos();
        }
    });

    $("#botonCancelar").click(function () {

        $("#mitabla tr:last").remove();
        $("#nombre").prop("disabled", false);
        $("#botonInsertar").attr("value", "Insertar");
        $(this).hide();
        $("#botonEditar").show();
        $("#botonBorrar").show();
        $("#nombre").focus();

    });

    $("#insertarForm").click(function(){
        $("#listado").hide();
        $("#formulario").show();
    })

    $("#buttonIns").click(function () {

        var cliente = {};
        cliente.dni = $("#dniIns").val();
        cliente.nombre = $("#nombreIns").val();
        cliente.apellido = $("#apellidoIns").val();

        $.ajax({
            url: "api/clientes",
            type: "POST",
            data: JSON.stringify(cliente),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            error: function (response) {
                //console.log(response.responseText);
            },
            success: function (response) {
                $("#listado").show();
                $("#formulario").hide();
                buscarTodos();
            }
        })

    });
});

function borrar(dni) {

    $.ajax({
        url: "/api/clientes" + dni,
        type: "DELETE",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (response) {
            //console.log(response.responseText);
            buscarTodos();
        },
        success: function (response) {

            buscarTodos();
        }
    });
}

function buscarTodos() {
    $.getJSON("/api/clientes", function (datos) {

        $("#mitabla").empty();
        $("#mitabla").append(
            `<tr>
                <th>DNI</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>
                    Borrar
                </th>
                <th>
                    Editar
                </th>
            </tr>`);

        for (let i = 0; i < datos.length; i++) {

            $("#mitabla").append(
                `<tr>
                        <td>${datos[i].dni}</td>
                        <td>${datos[i].nombre}</td>
                        <td>${datos[i].apellido}</td>
                        <td>
                            <a href="" onclick="borrar('/${datos[i].dni}');
                            return false;">❌</a>
                        </td>
                        <td>
                            📂
                        </td>
                    </tr>`);
        }
    });

}

function insertar(){

    var cliente = {};

    //cliente.dni = $("#dniIns").attr("value");
    cliente.dni = $("#insDni").val();
    cliente.nombre = $("#insNombre").val();
    cliente.apellido = $("#insApellido").val();


    $.ajax({
        url: "/api/clientes",
        type: "POST",
        data: JSON.stringify(cliente),
        contentType: "application/json; charset=utf-8",
        error: function (response) {
            console.dir(response);
        },
        success: function (response) {

            buscarTodos();
        }
    });
}