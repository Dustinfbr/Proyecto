using System;
using System.Collections.Generic;
using System.Text;

namespace master
{
    class Secretaria
    {
        private int Id_Secretaria { get; set; }
        private String Nombre { get; set; } 
        private String Cedula { get; set; }

        public Secretaria(int Id, String Nom, String CI)
        {
            this.Id_Secretaria = Id;
            this.Nombre = Nom;
            this.Cedula = CI;
        }
    }
}
