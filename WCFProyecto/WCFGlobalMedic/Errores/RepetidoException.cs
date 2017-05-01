using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFGlobalMedic.Errores
{
      [DataContract]
    public class RepetidoException
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Description { get; set; }

    }
}