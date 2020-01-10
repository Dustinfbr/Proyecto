using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class Medicamento
    {
        private int Id_Medicamento { get; set; }
	    private int Id_Receta { get; set; }
        private String Nombre { get; set; }
        private String Dosis { get; set; }

        public Medicamento(int M, int R, String Nom, String Ds)
        {
            this.Id_Medicamento = M;
            this.Id_Receta = R;
            this.Nombre = Nom;
            this.Dosis = Ds;
        }
    }
}
