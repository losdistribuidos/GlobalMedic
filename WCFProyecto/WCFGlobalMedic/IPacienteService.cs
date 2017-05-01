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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPacienteService" in both code and config file together.
    [ServiceContract]
    public interface IPacienteService
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Paciente CrearMedico(Paciente medicoCrear);
        [OperationContract]
        Paciente ObtenerMedico(string codigo_paciente);
        [OperationContract]
        Paciente ModificarMedico(Paciente medicoModificar);
        [OperationContract]
        void EliminarMedico(string codigo_paciente);
        [OperationContract]
        List<Paciente> ListarMedicos();
    }
}
