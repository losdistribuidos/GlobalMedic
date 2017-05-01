using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFGlobalMedic.Dominio
{
    public class Usuario
    {
        [DataMember]
        public int codigo { get; set; }

        [DataMember]
        public string usuario { get; set; }
        
        [DataMember]
        public string contraseña { get; set; }
        
      

    }
}