using System;
using System.Collections.Generic;
using System.Text;

namespace master
{
    class HistoriaClinica
    {
        private int Id_HistoriaClinica { get; set; }
        private int Id_Paciente { get; set; }

        public HistoriaClinica(int HC, int Id)
        {
            this.Id_HistoriaClinica = HC;
            this.Id_Paciente = Id;
        }
    }
}
