using System;
using System.Collections.Generic;
using System.Text;

namespace master
{
    class CitaMedica
    {
        private int Id_CitaMedica { get; set;  }
	    private int Id_Secretaria { get; set; }
        private int Id_Doctor { get; set; }
        private int Id_HC { get; set; }
        private DateTime Fecha { get; set; }
        private String Hora { get; set; }

        public CitaMedica (int CM, int Secre, int Doc, int HC, DateTime fecha, String hora)
        {
            this.Id_CitaMedica = CM;
            this.Id_Secretaria = Secre;
            this.Id_Doctor = Doc;
            this.Id_HC = HC;
            this.Fecha = fecha;
            this.Hora = hora;
        }
    }
}
