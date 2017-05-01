using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCita" en el código y en el archivo de configuración a la vez.
    public class ServicioCita : IServicioCita
    {
        String strConn = @"server=(LOCAL)\MSSQLSERVER2008;Database=Clinica;user=sa;password=sql;Integrated Security=false;";
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataSet ObtenerCitaPorPacientes(string dni)
        {
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_CitasxPaciente";
            cmd.Parameters.AddWithValue("@dni", dni);
            DataSet dts = new DataSet();
            try
            {
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "CitasPorPaciente");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dts;
        }

    }
}
