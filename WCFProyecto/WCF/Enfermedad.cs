//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enfermedad
    {
        public Enfermedad()
        {
            this.Diagnostico = new HashSet<Diagnostico>();
        }
    
        public string codigo_enfermedad { get; set; }
        public string nombre_enfermedad { get; set; }
        public string enfermedad_Terminal { get; set; }
    
        public virtual ICollection<Diagnostico> Diagnostico { get; set; }
    }
}
