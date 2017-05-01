using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfMedico.Dominio;

namespace WcfMedico.Persistencia
{
    public class MedicoDAO
    {

        private string cadenaConexion = "Data Source=(local);Initial Catalog=Clinica;Integrated Security=SSPI;";

        public Medicos Crear(Medicos medicoCrear)
        {
            Medicos medicoCreado = null;
            string sql = "INSERT INTO dbo.Doctor VALUES (@cod, @nombre, @apellido, @direc, @tel, @email, @estado, @espec, @horario)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@cod", medicoCrear.Codigo));
                    comando.Parameters.Add(new SqlParameter("@nombre", medicoCrear.Nombre));
                    comando.Parameters.Add(new SqlParameter("@apellido", medicoCrear.Apellido));
                    comando.Parameters.Add(new SqlParameter("@direc", medicoCrear.Direccion));
                    comando.Parameters.Add(new SqlParameter("@tel", medicoCrear.Telefono));
                    comando.Parameters.Add(new SqlParameter("@email", medicoCrear.Email));
                    comando.Parameters.Add(new SqlParameter("@estado", medicoCrear.Estado));
                    comando.Parameters.Add(new SqlParameter("@espec", medicoCrear.Especialidad));
                    comando.Parameters.Add(new SqlParameter("@horario", medicoCrear.Horario));
                    comando.ExecuteNonQuery();
                }
            }
            medicoCreado = Obtener(medicoCrear.Codigo);
            return medicoCreado;

        }

        public Medicos Obtener(int cod)
        {
            Medicos medicoEncontrado = null;
            string sql = "SELECT * FROM dbo.Doctor WHERE codigo_doctor=@cod";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@cod", cod));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            medicoEncontrado = new Medicos()
                            {
                                Codigo = (int)resultado["codigo_doctor"],
                                Nombre = (string)resultado["nombre"],
                                Apellido = (string)resultado["apellido"],
                                Direccion = (string)resultado["direccion"],
                                Telefono = (string)resultado["telefono"],
                                Email = (string)resultado["email"],
                                Estado = (string)resultado["estado"],
                                Especialidad = (string)resultado["cod_especialidad"],
                                Horario = (string)resultado["codigo_horarios"]

                            };
                        }
                    }
                }
            }
            return medicoEncontrado;
        }

        public Medicos Modificar(Medicos medicoModificar)
        {
            Medicos medicoModificado = null;
            string sql = "UPDATE dbo.Doctor SET nombre=@nombre, apellido=@apellido, direccion=@direc, telefono=@tel, email=@email, estado=@estado, cod_especialidad=@espec, codigo_horarios=@horario WHERE codigo_doctor=@cod";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nombre", medicoModificar.Nombre));
                    comando.Parameters.Add(new SqlParameter("@apellido", medicoModificar.Apellido));
                    comando.Parameters.Add(new SqlParameter("@direc", medicoModificar.Direccion));
                    comando.Parameters.Add(new SqlParameter("@tel", medicoModificar.Telefono));
                    comando.Parameters.Add(new SqlParameter("@email", medicoModificar.Telefono));
                    comando.Parameters.Add(new SqlParameter("@estado", medicoModificar.Estado));
                    comando.Parameters.Add(new SqlParameter("@espec", medicoModificar.Especialidad));
                    comando.Parameters.Add(new SqlParameter("@horario", medicoModificar.Horario));
                    comando.Parameters.Add(new SqlParameter("@cod", medicoModificar.Codigo));
                    comando.ExecuteNonQuery();
                }
            }
            medicoModificado = Obtener(medicoModificar.Codigo);
            return medicoModificado;


        }

        public void Eliminar(int codigo)
        {
            string sql = "DELETE FROM dbo.Doctor WHERE codigo_doctor=@cod";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@cod", codigo));
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Medicos> Listar()
        {
            List<Medicos> medicosEncontrados = new List<Medicos>();
            Medicos medicoEncontrado = null;
            string sql = "SELECT * FROM dbo.Doctor";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            medicoEncontrado = new Medicos()
                            {
                                Codigo = (int)resultado["codigo_doctor"],
                                Nombre = (string)resultado["nombre"],
                                Apellido = (string)resultado["apellido"],
                                Direccion = (string)resultado["direccion"],
                                Telefono = (string)resultado["telefono"],
                                Email = (string)resultado["email"],
                                Estado = (string)resultado["estado"],
                                Especialidad = (string)resultado["cod_especialidad"],
                                Horario = (string)resultado["codigo_horarios"]
                            };
                            medicosEncontrados.Add(medicoEncontrado);
                        }
                    }

                }

            }


            return medicosEncontrados;
        }





    }
}