using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WCFGlobalMedic.Dominio;

namespace WCFGlobalMedic.Persistencia
{
    public class PacienteDAO
    {
        private string cadenaConexion = "Data Source=(local);Initial Catalog=Clinica;Integrated Security=SSPI;";

        public Paciente Crear(Paciente pacienteCrear)
        {
            Paciente pacienteCreado = null;
            string sql = "INSERT INTO dbo.Pacientes VALUES (@codigo_paciente, @nombre, @apellido, @fecha_nac, @sexo, @codigo_sala, @pais, @codigo_distrito, @emergencia, @ocupacion, @alergia)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigo_paciente", pacienteCrear.codigo_paciente));
                    comando.Parameters.Add(new SqlParameter("@nombre", pacienteCrear.nombre));
                    comando.Parameters.Add(new SqlParameter("@apellido", pacienteCrear.apellido));
                    comando.Parameters.Add(new SqlParameter("@fecha_nac", pacienteCrear.fecha_nac));
                    comando.Parameters.Add(new SqlParameter("@sexo", pacienteCrear.sexo));
                    comando.Parameters.Add(new SqlParameter("@codigo_sala", pacienteCrear.codigo_sala));
                    comando.Parameters.Add(new SqlParameter("@pais", pacienteCrear.pais));
                    comando.Parameters.Add(new SqlParameter("@codigo_distrito", pacienteCrear.codigo_distrito));
                    comando.Parameters.Add(new SqlParameter("@emergencia", pacienteCrear.emergencia));
                    comando.Parameters.Add(new SqlParameter("@ocupacion", pacienteCrear.ocupacion));
                    comando.Parameters.Add(new SqlParameter("@alergia", pacienteCrear.alergia));

                    comando.ExecuteNonQuery();
                }
            }
            pacienteCreado = Obtener(pacienteCrear.codigo_paciente);
            return pacienteCreado;

        }


        public Paciente Obtener(string dni)
        {
            Paciente pacienteEncontrado = null;
            string sql = "SELECT * FROM dbo.Pacientes WHERE codigo_paciente=@codigo_paciente";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigo_paciente", dni));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            pacienteEncontrado = new Paciente()
                            {
                                codigo_paciente = (string)resultado["codigo_paciente"],
                                nombre = (string)resultado["nombre"],
                                apellido = (string)resultado["apellido"],
                                fecha_nac = (DateTime)resultado["fecha_nac"],
                                  sexo = (string)resultado["sexo"],
                                codigo_sala = (string)resultado["codigo_sala"],
                                pais = (string)resultado["pais"],
                                codigo_distrito = (string)resultado["codigo_distrito"],
                                  emergencia = (string)resultado["emergencia"],
                                ocupacion = (string)resultado["ocupacion"],
                                alergia = (string)resultado["alergia"]

                            };
                        }
                    }
                }
            }
            return pacienteEncontrado;
        }
        public Paciente Modificar(Paciente pacienteModificar)
        {
            Paciente medicoModificado = null;
            string sql = "UPDATE dbo.Pacientes SET nombre=@nombre,apellido=@apellido, fecha_nac=@fecha_nac,sexo=@sexo,codigo_sala=@codigo_sala,pais=@pais,codigo_distrito=@codigo_distrito,emergencia=@emergencia,ocupacion=@ocupacion,alergia=@alergia WHERE codigo_paciente=@codigo_paciente";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nombre", pacienteModificar.nombre));
                    comando.Parameters.Add(new SqlParameter("@apellido", pacienteModificar.apellido));
                    comando.Parameters.Add(new SqlParameter("@fecha_nac", pacienteModificar.fecha_nac));
                    comando.Parameters.Add(new SqlParameter("@sexo", pacienteModificar.sexo));
                    comando.Parameters.Add(new SqlParameter("@codigo_sala", pacienteModificar.codigo_sala));
                    comando.Parameters.Add(new SqlParameter("@pais", pacienteModificar.pais));
                    comando.Parameters.Add(new SqlParameter("@codigo_distrito", pacienteModificar.codigo_distrito));
                    comando.Parameters.Add(new SqlParameter("@emergencia", pacienteModificar.emergencia));
                    comando.Parameters.Add(new SqlParameter("@ocupacion", pacienteModificar.ocupacion));
                    comando.Parameters.Add(new SqlParameter("@alergia", pacienteModificar.alergia));
                    comando.ExecuteNonQuery();
                }
            }
            medicoModificado = Obtener(pacienteModificar.codigo_paciente);
            return medicoModificado;


        }
        public void Eliminar(string codigo_paciente)
        {
            string sql = "DELETE FROM dbo.Paciente WHERE codigo_paciente=@codigo_paciente";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigo_paciente", codigo_paciente));
                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Paciente> Listar()
        {
            List<Paciente> PacienteEncontrados = new List<Paciente>();
            Paciente medicoEncontrado = null;
            string sql = "SELECT * FROM dbo.Pacientes";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            medicoEncontrado = new Paciente()
                            {
                                codigo_paciente = (string)resultado["codigo_paciente"],
                                nombre = (string)resultado["nombre"],
                                apellido = (string)resultado["apellido"],
                                fecha_nac = (DateTime)resultado["fecha_nac"],
                                sexo = (string)resultado["sexo"],
                                codigo_sala = (string)resultado["codigo_sala"],
                                pais = (string)resultado["pais"],
                                codigo_distrito = (string)resultado["codigo_distrito"],
                                emergencia = (string)resultado["emergencia"],
                                ocupacion = (string)resultado["ocupacion"],
                                alergia = (string)resultado["alergia"]
                            };
                            PacienteEncontrados.Add(medicoEncontrado);
                        }
                    }

                }

            }


            return PacienteEncontrados;
        }
    }
}