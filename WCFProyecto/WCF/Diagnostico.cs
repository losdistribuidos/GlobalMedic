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
    
    public partial class Diagnostico
    {
        public string codigo_diagnostico { get; set; }
        public string codigo_cita { get; set; }
        public string codigo_paciente { get; set; }
        public string codigo_enfermedad { get; set; }
        public string medicamento { get; set; }
        public decimal talla { get; set; }
        public string enf_terminal { get; set; }
        public decimal pesopaciente { get; set; }
        public Nullable<System.DateTime> fecha_diagnostico { get; set; }
    
        public virtual Cita Cita { get; set; }
        public virtual Enfermedad Enfermedad { get; set; }
        public virtual Pacientes Pacientes { get; set; }
    }
}
