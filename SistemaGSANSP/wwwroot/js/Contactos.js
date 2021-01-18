
class Contactos {

    RegistrarContacto() {
        $.post(
            "GetContactos",
            $('.formContacto').serialize(),
            (response) => {
                console.log(response);
            }
        );
    }
}
