function validarCajaNoVacia(idcaja) {

    var eCaja = document.getElementById(idcaja);
    if (eCaja.value != "") {
        return true; // la caja no está vacía
    } else {
        return false;
    }

}

function validarImporteMinimo(caja, importeMinimo){
            
    var importeCaja = document.getElementById(caja).value;
    
    return importeCaja>=importeMinimo?true:false;

}
