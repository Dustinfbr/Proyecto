using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class SignosVitales
    {
        private int Id_SignoVital { get; set; }
	    private int Id_CitaMedica { get; set; }
        private float Altura { get; set; }
        private float Peso { get; set; }
        private float Temperatura { get; set; }
        private float PresionA { get; set; }
        private float PresionB { get; set; }
        private float RitmoCardiaco { get; set; }
        private float Saturacion { get; set; }

        public SignosVitales(int SG, int CM, float Alt, float Pes, float Temp,
                             float PA, float PB, float RC, float SOx)
        {
            this.Id_SignoVital = SG;
            this.Id_CitaMedica = CM;
            this.Altura = Alt;
            this.Peso = Pes;
            this.Temperatura = Temp;
            this.PresionA = PA;
            this.PresionB = PB;
            this.RitmoCardiaco = RC;
            this.Saturacion = SOx;
        }
    }
}
