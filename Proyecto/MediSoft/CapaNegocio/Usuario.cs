using System;

namespace CapaNegocio
{
    public class Usuario
    {
        public String usuario { get; set; }
        public String contrasenia { get; set; }

        public Usuario(String usuario, String contraseña)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }

              
        
    }
}
