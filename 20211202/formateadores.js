function mostrarErrorCaja(idcaja, iderror, color) {

    var eError = document.getElementById(iderror);

    if (validarCajaNoVacia(idcaja)) {
        
        eError.style.backgroundColor = "#FFFFFF";
    } else {
        eError.style.backgroundColor = color;
    }
}
