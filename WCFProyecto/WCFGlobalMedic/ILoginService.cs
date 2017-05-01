using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFGlobalMedic.Dominio;
using WCFGlobalMedic.Errores;

namespace WCFGlobalMedic
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ILoginService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ILoginService
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Usuario Crear(Usuario UsuarioCrear);
        [OperationContract]
        Usuario Obtener(int codigo);
        [OperationContract]
        Usuario Modificar(Usuario UsuarioModificar);
        [OperationContract]
        void Eliminar(string usuario);
        [OperationContract]
        List<Usuario> Listar();
    }
}
