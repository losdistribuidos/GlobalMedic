﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicaUnitTest.MedicosWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Medicos", Namespace="http://schemas.datacontract.org/2004/07/WcfMedico.Dominio")]
    [System.SerializableAttribute()]
    public partial class Medicos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EspecialidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HorarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Especialidad {
            get {
                return this.EspecialidadField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadField, value) != true)) {
                    this.EspecialidadField = value;
                    this.RaisePropertyChanged("Especialidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Horario {
            get {
                return this.HorarioField;
            }
            set {
                if ((object.ReferenceEquals(this.HorarioField, value) != true)) {
                    this.HorarioField = value;
                    this.RaisePropertyChanged("Horario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WcfMedico.Errores")]
    [System.SerializableAttribute()]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MedicosWS.IMedico")]
    public interface IMedico {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/CrearMedico", ReplyAction="http://tempuri.org/IMedico/CrearMedicoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClinicaUnitTest.MedicosWS.RepetidoException), Action="http://tempuri.org/IMedico/CrearMedicoRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WcfMedico.Errores")]
        ClinicaUnitTest.MedicosWS.Medicos CrearMedico(ClinicaUnitTest.MedicosWS.Medicos medicoCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/CrearMedico", ReplyAction="http://tempuri.org/IMedico/CrearMedicoResponse")]
        System.Threading.Tasks.Task<ClinicaUnitTest.MedicosWS.Medicos> CrearMedicoAsync(ClinicaUnitTest.MedicosWS.Medicos medicoCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/ObtenerMedico", ReplyAction="http://tempuri.org/IMedico/ObtenerMedicoResponse")]
        ClinicaUnitTest.MedicosWS.Medicos ObtenerMedico(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/ObtenerMedico", ReplyAction="http://tempuri.org/IMedico/ObtenerMedicoResponse")]
        System.Threading.Tasks.Task<ClinicaUnitTest.MedicosWS.Medicos> ObtenerMedicoAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/ModificarMedico", ReplyAction="http://tempuri.org/IMedico/ModificarMedicoResponse")]
        ClinicaUnitTest.MedicosWS.Medicos ModificarMedico(ClinicaUnitTest.MedicosWS.Medicos medicoModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/ModificarMedico", ReplyAction="http://tempuri.org/IMedico/ModificarMedicoResponse")]
        System.Threading.Tasks.Task<ClinicaUnitTest.MedicosWS.Medicos> ModificarMedicoAsync(ClinicaUnitTest.MedicosWS.Medicos medicoModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/EliminarMedico", ReplyAction="http://tempuri.org/IMedico/EliminarMedicoResponse")]
        void EliminarMedico(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/EliminarMedico", ReplyAction="http://tempuri.org/IMedico/EliminarMedicoResponse")]
        System.Threading.Tasks.Task EliminarMedicoAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/ListarMedicos", ReplyAction="http://tempuri.org/IMedico/ListarMedicosResponse")]
        ClinicaUnitTest.MedicosWS.Medicos[] ListarMedicos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedico/ListarMedicos", ReplyAction="http://tempuri.org/IMedico/ListarMedicosResponse")]
        System.Threading.Tasks.Task<ClinicaUnitTest.MedicosWS.Medicos[]> ListarMedicosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMedicoChannel : ClinicaUnitTest.MedicosWS.IMedico, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MedicoClient : System.ServiceModel.ClientBase<ClinicaUnitTest.MedicosWS.IMedico>, ClinicaUnitTest.MedicosWS.IMedico {
        
        public MedicoClient() {
        }
        
        public MedicoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MedicoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClinicaUnitTest.MedicosWS.Medicos CrearMedico(ClinicaUnitTest.MedicosWS.Medicos medicoCrear) {
            return base.Channel.CrearMedico(medicoCrear);
        }
        
        public System.Threading.Tasks.Task<ClinicaUnitTest.MedicosWS.Medicos> CrearMedicoAsync(ClinicaUnitTest.MedicosWS.Medicos medicoCrear) {
            return base.Channel.CrearMedicoAsync(medicoCrear);
        }
        
        public ClinicaUnitTest.MedicosWS.Medicos ObtenerMedico(int codigo) {
            return base.Channel.ObtenerMedico(codigo);
        }
        
        public System.Threading.Tasks.Task<ClinicaUnitTest.MedicosWS.Medicos> ObtenerMedicoAsync(int codigo) {
            return base.Channel.ObtenerMedicoAsync(codigo);
        }
        
        public ClinicaUnitTest.MedicosWS.Medicos ModificarMedico(ClinicaUnitTest.MedicosWS.Medicos medicoModificar) {
            return base.Channel.ModificarMedico(medicoModificar);
        }
        
        public System.Threading.Tasks.Task<ClinicaUnitTest.MedicosWS.Medicos> ModificarMedicoAsync(ClinicaUnitTest.MedicosWS.Medicos medicoModificar) {
            return base.Channel.ModificarMedicoAsync(medicoModificar);
        }
        
        public void EliminarMedico(int codigo) {
            base.Channel.EliminarMedico(codigo);
        }
        
        public System.Threading.Tasks.Task EliminarMedicoAsync(int codigo) {
            return base.Channel.EliminarMedicoAsync(codigo);
        }
        
        public ClinicaUnitTest.MedicosWS.Medicos[] ListarMedicos() {
            return base.Channel.ListarMedicos();
        }
        
        public System.Threading.Tasks.Task<ClinicaUnitTest.MedicosWS.Medicos[]> ListarMedicosAsync() {
            return base.Channel.ListarMedicosAsync();
        }
    }
}
