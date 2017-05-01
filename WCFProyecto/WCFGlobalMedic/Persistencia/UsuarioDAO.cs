using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WCFGlobalMedic.Dominio;

namespace WCFGlobalMedic.Persistencia
{
    public class UsuarioDAO
    {
        private string cadenaConexion = "Data Source=(local);Initial Catalog=Clinica;Integrated Security=SSPI;";

        public Usuario Crear(Usuario UsuarioCrear)
        {
            Usuario UsuarioCreado = null;
            string sql = "INSERT INTO USUARIOS (CODIGO, USUARIO, CONTRASEÑA) VALUES (@CODIGO, @USUARIO, @CONTRASEÑA)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@CODIGO", UsuarioCrear.codigo));
                    comando.Parameters.Add(new SqlParameter("@USUARIO", UsuarioCrear.usuario));
                    comando.Parameters.Add(new SqlParameter("@CONTRASEÑA", UsuarioCrear.contraseña));
                    comando.ExecuteNonQuery();
                }
            }
            UsuarioCreado = Obtener(UsuarioCrear.codigo);
            return UsuarioCreado;
        }


        public Usuario Obtener(int Codigo)
        {
            Usuario UsuarioEncontrado = null;

            string sql = "SELECT * FROM dbo.USUARIOS WHERE CODIGO = @CODIGO";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigo", Codigo));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            UsuarioEncontrado = new Usuario()
                            {
                                codigo = (int)resultado["codigo"],
                                usuario = (string)resultado["usuario"],
                                contraseña = (string)resultado["contraseña"],
                                
                            };
                        }
                    }
                }
            }
            return UsuarioEncontrado;
        }
        public Usuario Modificar(Usuario UsuarioModificar)
        {
            Usuario medicoModificado = null;
            string sql = "UPDATE dbo.Usuarios SET codigo=@codigo,contraseña=@contraseña WHERE usuario=@usuario";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigo", UsuarioModificar.codigo));
                    comando.Parameters.Add(new SqlParameter("@usuario", UsuarioModificar.usuario));
                    comando.Parameters.Add(new SqlParameter("@contraseña", UsuarioModificar.contraseña));
                  
                   comando.ExecuteNonQuery();
                }
            }
            medicoModificado = Obtener(UsuarioModificar.codigo);
            return medicoModificado;


        }
        public void Eliminar(string usuario)
        {
            string sql = "DELETE FROM dbo.Usuario WHERE usuario=@usuario";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@usuario", usuario));
                    comando.ExecuteNonQuery();
                }
            }
        }
        public List<Usuario> Listar()
        {
            List<Usuario> UsuarioEncontrados = new List<Usuario>();
            Usuario medicoEncontrado = null;
            string sql = "SELECT * FROM dbo.Usuarios";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            medicoEncontrado = new Usuario()
                            {
                                codigo = (int)resultado["codigo"],
                                usuario = (string)resultado["usuario"],
                                contraseña = (string)resultado["contraseña"],
                         };
                            UsuarioEncontrados.Add(medicoEncontrado);
                        }
                    }

                }

            }


            return UsuarioEncontrados;
        }


    }
}