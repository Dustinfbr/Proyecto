using System;
using System.Collections.Generic;
using System.Text;
using DAOCapa;
using System.Data;

namespace CapaNegocio
{
    public class Paciente
    {
	    private String Cedula { get; set; }
        private String Nombres { get; set; }
        private String Apellidos { get; set; }
        private String Sexo { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private int Edad { get; set; }

        ManejadorDB mDB = new ManejadorDB();


        public Paciente(String CI, String Nom, String Apell, String Sex, DateTime Fecha)
        {
            this.Cedula = CI;
            this.Nombres = Nom;
            this.Apellidos = Apell;
            this.Sexo = Sex;
            this.FechaNacimiento = Fecha.Date;
            this.Edad = this.CalculoEdad(Fecha.Date);
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

        public String AgregarPaciente()
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@Cedula", Cedula));
                lstparametros.Add(new ParametrosDB("@Nombres", Nombres));
                lstparametros.Add(new ParametrosDB("@Apellidos", Apellidos));
                lstparametros.Add(new ParametrosDB("@Sexo", Sexo));
                lstparametros.Add(new ParametrosDB("@FechaNacimiento", FechaNacimiento));
                lstparametros.Add(new ParametrosDB("@Edad", Edad));
                //parametros de salida
                lstparametros.Add(new ParametrosDB("@mensaje", SqlDbType.VarChar, 100));

                mDB.EjecutarProcedimiento("AgregarPaciente",lstparametros);

                msj = lstparametros[2].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }

        public DataTable listarPacientes()
        {
            return mDB.registros("listarPacientes", null);
        }
        
    }
}
