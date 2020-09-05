function mostrarModal(titulo = "¿Desea guardar los cambios?", texto = "Se guardará los datos en la base de datos") {
    return Swal.fire
        ({
            title: titulo,
            text: texto,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si!'
        })
}

function EliminarModal(titulo = "¿Desea eliminar el registro?", texto = "Se eliminará el registro en la base de datos") {
    return Swal.fire
        ({
            title: titulo,
            text: texto,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si!'
        })
}

function ActualizarModal(titulo = "¿Desea actualizar el registro?", texto = "Se actualizará el registro en la base de datos") {
    return Swal.fire
        ({
            title: titulo,
            text: texto,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si!'
        })
}


