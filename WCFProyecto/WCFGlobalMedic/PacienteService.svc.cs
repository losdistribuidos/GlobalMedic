using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFGlobalMedic.Dominio;
using WCFGlobalMedic.Errores;
using WCFGlobalMedic.Persistencia;

namespace WCFGlobalMedic
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PacienteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PacienteService.svc or PacienteService.svc.cs at the Solution Explorer and start debugging.
    public class PacienteService : IPacienteService
    {
        private PacienteDAO medicoDAO = new PacienteDAO();
        public Paciente CrearMedico(Paciente medicoCrear)
        {
            if (medicoDAO.Obtener(medicoCrear.codigo_paciente) != null) // Ya existe
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "98765432",
                        Description = "El medico ya existe"
                    },
                    new FaultReason("Error al intentar creación"));
            }
            return medicoDAO.Crear(medicoCrear);
        }

        public void EliminarMedico(string codigo_paciente)
        {
            medicoDAO.Eliminar(codigo_paciente);
        }

        public List<Paciente> ListarMedicos()
        {
            return medicoDAO.Listar();
        }

        public Paciente ModificarMedico(Paciente medicoModificar)
        {
            return medicoDAO.Modificar(medicoModificar);
        }

        public Paciente ObtenerMedico(string codigo_paciente)
        {
            return medicoDAO.Obtener(codigo_paciente);
        }
    }
}
