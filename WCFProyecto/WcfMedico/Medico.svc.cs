using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfMedico.Dominio;
using WcfMedico.Errores;
using WcfMedico.Persistencia;

namespace WcfMedico
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Medico" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Medico.svc o Medico.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Medico : IMedico
    {
        private MedicoDAO medicoDAO = new MedicoDAO();
        public Medicos CrearMedico(Medicos medicoCrear)
        {
            if (medicoDAO.Obtener(medicoCrear.Codigo) != null) // Ya existe
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "101",
                        Description = "El medico ya existe"
                    },
                    new FaultReason("Error al intentar creación"));
            }
            return medicoDAO.Crear(medicoCrear);
        }

        public void EliminarMedico(int codigo)
        {
            medicoDAO.Eliminar(codigo);
        }

        public List<Medicos> ListarMedicos()
        {
            return medicoDAO.Listar();
        }

        public Medicos ModificarMedico(Medicos medicoModificar)
        {
            return medicoDAO.Modificar(medicoModificar);
        }

        public Medicos ObtenerMedico(int codigo)
        {
            return medicoDAO.Obtener(codigo);
        }
    }
}
