using System;
using System.Collections.Generic;
using System.Text;

namespace master
{
    class RecetaMedica
    {
        private int Id_Receta { get; set; }
	    private int Id_CitaMedica { get; set; }

        public RecetaMedica(int R, int CM)
        {
            this.Id_Receta = R;
            this.Id_Receta = CM;
        }
    }
}
