using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;


namespace CapaNegocio
{
    public class SignoVital
    {
        private double Altura { get; set; }
        private double Peso { get; set; }
        private double Temperatura { get; set; }
        private double PresionA { get; set; }
        private double PresionB { get; set; }
        private double RitmoCardiaco { get; set; }
        private double Saturacion { get; set; }

        public SignoVital(String Alt, String Pes, String Temp,
                          String PA, String PB, String RC, String SOx)
        {

            this.Altura = Convert.ToDouble(Alt);
            this.Peso = Convert.ToDouble(Pes);
            this.Temperatura = Convert.ToDouble(Temp);
            this.PresionA = Convert.ToDouble(PA);
            this.PresionB = Convert.ToDouble(PB);
            this.RitmoCardiaco = Convert.ToDouble(RC);
            this.Saturacion = Convert.ToDouble(SOx);
        }

        public SignoVital()
        {

        }
        public void agregarSignos(String CI)
        {
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@CI", CI));
                lstparametros.Add(new ParametrosDB("@Altura", Altura));
                lstparametros.Add(new ParametrosDB("@Peso", Peso));
                lstparametros.Add(new ParametrosDB("@Temperatura", Temperatura));
                lstparametros.Add(new ParametrosDB("@PresionA", PresionA));
                lstparametros.Add(new ParametrosDB("@PresionB", PresionB));
                lstparametros.Add(new ParametrosDB("@RitmoCardiaco", RitmoCardiaco));
                lstparametros.Add(new ParametrosDB("@Saturacion", Saturacion));
                //parametros de salida
                ManejadorDB.Instancia.EjecutarProcedimiento("agregarSignos", lstparametros);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public double CalculoIMC(String altura,String peso)           
        {
            double IMC;
            double a = Convert.ToDouble(altura);
            double b = Convert.ToDouble(peso);
            IMC = b / Math.Pow(a, 2);
            return IMC;
        }
    }
}
