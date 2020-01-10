using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class HistoriaClinica
    {
        private String Alergias { get; set; }
        private String Enfermedades { get; set; }
        public HistoriaClinica(String Aler, String Enfe)
        {
            this.Alergias = Aler;
            this.Enfermedades = Enfe;
        }
        public HistoriaClinica() 
        {
            
        }

        ManejadorDB mDB = new ManejadorDB();
        public String agregarHC(String CI)
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@CIPaciente", CI ));
                lstparametros.Add(new ParametrosDB("@Alergia", Alergias));
                lstparametros.Add(new ParametrosDB("@Enfermedades", Enfermedades));
                //parametros de salida
                mDB.EjecutarProcedimiento("agregarHC", lstparametros);

                msj = lstparametros[2].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }

        public String modificarHC(String CI)
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@CIPaciente", CI));
                lstparametros.Add(new ParametrosDB("@Alergia", Alergias));
                lstparametros.Add(new ParametrosDB("@Enfermedades", Enfermedades));
                //parametros de salida
                mDB.EjecutarProcedimiento("modificarHC", lstparametros);

                msj = lstparametros[2].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }
        public String MostrarA(String CI)
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@CI", CI));
                //parametros de salida
                lstparametros.Add(new ParametrosDB("@Alergia", SqlDbType.VarChar, 100));
                mDB.EjecutarProcedimiento("MostrarA", lstparametros);

                msj = lstparametros[1].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }
        public String MostrarE(String CI)
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@CI", CI));
                //parametros de salida
                lstparametros.Add(new ParametrosDB("@Enfermedades", SqlDbType.VarChar, 300));
                mDB.EjecutarProcedimiento("MostrarE", lstparametros);

                msj = lstparametros[1].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }

        public DataTable listarHC()
        {
            return mDB.registros("listarHC", null);
        }

        public DataTable buscarHC(String CI)
        {
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@CI", CI));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return mDB.registros("buscarHC", lstparametros);

        }

        public String eliminarHC(String CI)
        {
            String msj = "";
            List<ParametrosDB> lstparametros = new List<ParametrosDB>();
            try
            {
                //parametros de entrada
                lstparametros.Add(new ParametrosDB("@CI", CI));
                //parametros de salida
                mDB.EjecutarProcedimiento("eliminarHC", lstparametros);

                msj = lstparametros[1].valor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return msj;
        }
    }
}
