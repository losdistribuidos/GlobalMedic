using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFGlobalMedic.Dominio
{
    [DataContract]
    public class Paciente
    {
        [DataMember]
        public string codigo_paciente { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string apellido { get; set; }
        [DataMember]
        public DateTime fecha_nac { get; set; }
        [DataMember]
        public string sexo { get; set; }
        [DataMember]
        public string codigo_sala { get; set; }
        [DataMember]
        public string pais { get; set; }
        [DataMember]
        public string codigo_distrito { get; set; }
        [DataMember]
        public string emergencia { get; set; }
        [DataMember]
        public string ocupacion { get; set; }
        [DataMember]
        public string alergia { get; set; }

    }
}