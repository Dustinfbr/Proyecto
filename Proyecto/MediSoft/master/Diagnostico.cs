using System;
using System.Collections.Generic;
using System.Text;

namespace master
{
    class Diagnostico
    {
        private int Id_Diagnostico { get; set; }
	    private int Id_CitaMedica { get; set; }
        private String Indicaciones { get; set; }

        public Diagnostico (int Diag, int CM, String Indicacion)
        {
            this.Id_Diagnostico = Diag;
            this.Id_CitaMedica = CM;
            this.Indicaciones= Indicacion;
        }
    }
}
