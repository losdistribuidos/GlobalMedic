using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfMedico.Dominio
{
    public class Medicos
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember(IsRequired = false)]
        public string Estado { get; set; }
        [DataMember]
        public string Especialidad { get; set; }
        [DataMember]
        public string Horario { get; set; }
    }
}