using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class Doctor
    {
        private int Id_Doctor { get; set; }
	    private String Nombre { get; set; }
	    private String Cedula { get; set; }
	    private String Especialidad { get; set; }

        public Doctor(int Id, String Nom, String CI, String Espe)
        {
            this.Id_Doctor = Id;
            this.Nombre = Nom;
            this.Cedula = CI;
            this.Especialidad = Espe;
        }
    }
}
