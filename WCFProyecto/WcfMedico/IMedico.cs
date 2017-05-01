using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfMedico.Dominio;
using WcfMedico.Errores;

namespace WcfMedico
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMedico" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMedico
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Medicos CrearMedico(Medicos medicoCrear);
        [OperationContract]
        Medicos ObtenerMedico(int codigo);
        [OperationContract]
        Medicos ModificarMedico(Medicos medicoModificar);
        [OperationContract]
        void EliminarMedico(int codigo);
        [OperationContract]
        List<Medicos> ListarMedicos();
    }
}
