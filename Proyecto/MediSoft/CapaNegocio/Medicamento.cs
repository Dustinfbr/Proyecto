using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Medicamento
    {
       
        private int Id_Receta { get; set; }
        private String Nombre { get; set; }
        private String Dosis { get; set; }

        ManejadorDB mDB = new ManejadorDB();

        public Medicamento(int R, String Nom, String Ds)
        {
           
            this.Id_Receta = R;
            this.Nombre = Nom;
            this.Dosis = Ds;
        }

        public Medicamento() { }

        public String ingresarMed()
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@Id_Receta", Id_Receta));
                lstparametros.Add(new ParametrosDB("@Nombre", Nombre));
                lstparametros.Add(new ParametrosDB("@Dosis", Dosis));
                //parametros de salida
                

                mDB.EjecutarProcedimiento("ingresarMed", lstparametros);

                msj = lstparametros[2].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }


        public String actualizarMed()
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@Id_Receta", Id_Receta));
                lstparametros.Add(new ParametrosDB("@Nombre", Nombre));
                lstparametros.Add(new ParametrosDB("@Dosis", Dosis));
                //parametros de salida


                mDB.EjecutarProcedimiento("actualizarMed", lstparametros);

                msj = lstparametros[2].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }

        public String eliminarMed()
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@Id_Receta", Id_Receta));
                lstparametros.Add(new ParametrosDB("@Nombre", Nombre));
                //parametros de salida


                mDB.EjecutarProcedimiento("eliminarMed", lstparametros);

                msj = lstparametros[2].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }



        public DataTable listaMedicinas()
        {
            return mDB.registros("listarMed", null);
        }
    }
   
}
