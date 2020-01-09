using System;
using System.Collections.Generic;
using System.Text;

namespace master
{
    class Paciente
    {
        private int Id_Paciente { get; set; }
	    private String Cedula { get; set; }
        private String Nombres { get; set; }
        private String Apellidos { get; set; }
        private String Sexo { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private int Edad { get; set; }

        public Paciente(int Id, String CI, String Nom, String Apell, String Sex, 
                        DateTime Fecha)
        {
            this.Id_Paciente = Id;
            this.Cedula = CI;
            this.Nombres = Nom;
            this.Apellidos = Apell;
            this.Sexo = Sex;
            this.FechaNacimiento = Fecha;
            this.Edad = this.CalculoEdad(Fecha);
        }

        public int CalculoEdad(DateTime fecha)
        {
            int edad;
            DateTime hoy = DateTime.Today;
            if(hoy.Month > fecha.Month)
            {
                edad = hoy.Year - fecha.Year - 1;
            }
            else
            {
                edad = hoy.Year - fecha.Year;
            }
            return edad;
        }
    }
}
