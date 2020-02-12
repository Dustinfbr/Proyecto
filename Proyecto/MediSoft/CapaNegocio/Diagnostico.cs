using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Diagnostico
    {
        private int Id_Diagnostico { get; set; }
	    private int Id_CitaMedica { get; set; }
        private String Indicaciones { get; set; }

        public Diagnostico (String Indicacion)
        {
            this.Indicaciones= Indicacion;
        }

        public String AgregarDiagnostico(String Cedula)
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@Cedula", Cedula));
                lstparametros.Add(new ParametrosDB("@Indicaciones", Indicaciones));
            
                ManejadorDB.Instancia.EjecutarProcedimiento("agregarDiagnostico", lstparametros);

                msj = lstparametros[2].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }
    }
}
