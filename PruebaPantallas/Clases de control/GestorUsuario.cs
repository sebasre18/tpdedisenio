using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    class GestorUsuario
    {
        public Clases_de_entidad.Usuario crearUsuario()
        {
            /* Crea un usuario para usar en los casos que se necesita contar con Usuario Autentificado */
            string unEmail = "PETERLANGUILA@LOL.COM";
            string unaContraseña = "peter22";
            string unApellido = "LANGUILA";
            string unNombre = "PETER";
            Clases_de_entidad.Usuario unUsuario = new Clases_de_entidad.Usuario(unEmail, unaContraseña, unApellido, unNombre);

            return unUsuario;
        }
    }
}
