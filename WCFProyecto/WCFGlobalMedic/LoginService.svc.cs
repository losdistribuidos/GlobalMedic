using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFGlobalMedic.Dominio;
using WCFGlobalMedic.Errores;
using WCFGlobalMedic.Persistencia;

namespace WCFGlobalMedic
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "LoginService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione LoginService.svc o LoginService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class LoginService : ILoginService
    {
        private UsuarioDAO UsuarioDAO = new UsuarioDAO();
        public Usuario Crear(Usuario UsuarioCrear)
        {
            if (UsuarioDAO.Obtener(UsuarioCrear.codigo) != null) // Ya existe
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "98765432",
                        Description = "El usuario ya existe"
                    },
                    new FaultReason("Error al intentar creación"));
            }
            return UsuarioDAO.Crear (UsuarioCrear);
        }

        public void Eliminar(string usuario)
        {
            UsuarioDAO.Eliminar(usuario);
        }

        public List<Usuario> Listar()
        {
            return UsuarioDAO.Listar();
        }

        public Usuario Modificar(Usuario UsuarioModificar)
        {
            return UsuarioDAO.Modificar(UsuarioModificar);
        }

        public Usuario Obtener(int codigo)
        {
            return UsuarioDAO.Obtener(codigo);
        }
    }
}
