﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Progetto.PiantaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="pianta", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class pianta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ordinataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double prezzolavoroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double prezzopiantaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int tagliaField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ordinata {
            get {
                return this.ordinataField;
            }
            set {
                if ((this.ordinataField.Equals(value) != true)) {
                    this.ordinataField = value;
                    this.RaisePropertyChanged("ordinata");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double prezzolavoro {
            get {
                return this.prezzolavoroField;
            }
            set {
                if ((this.prezzolavoroField.Equals(value) != true)) {
                    this.prezzolavoroField = value;
                    this.RaisePropertyChanged("prezzolavoro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double prezzopianta {
            get {
                return this.prezzopiantaField;
            }
            set {
                if ((this.prezzopiantaField.Equals(value) != true)) {
                    this.prezzopiantaField = value;
                    this.RaisePropertyChanged("prezzopianta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int taglia {
            get {
                return this.tagliaField;
            }
            set {
                if ((this.tagliaField.Equals(value) != true)) {
                    this.tagliaField = value;
                    this.RaisePropertyChanged("taglia");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PiantaService.IPiantaService")]
    public interface IPiantaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPiantaService/findAll", ReplyAction="http://tempuri.org/IPiantaService/findAllResponse")]
        Progetto.PiantaService.pianta[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPiantaService/findAll", ReplyAction="http://tempuri.org/IPiantaService/findAllResponse")]
        System.Threading.Tasks.Task<Progetto.PiantaService.pianta[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPiantaService/find", ReplyAction="http://tempuri.org/IPiantaService/findResponse")]
        Progetto.PiantaService.pianta find(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPiantaService/find", ReplyAction="http://tempuri.org/IPiantaService/findResponse")]
        System.Threading.Tasks.Task<Progetto.PiantaService.pianta> findAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPiantaService/Addpianta", ReplyAction="http://tempuri.org/IPiantaService/AddpiantaResponse")]
        void Addpianta(Progetto.PiantaService.pianta pianta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPiantaService/Addpianta", ReplyAction="http://tempuri.org/IPiantaService/AddpiantaResponse")]
        System.Threading.Tasks.Task AddpiantaAsync(Progetto.PiantaService.pianta pianta);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPiantaServiceChannel : Progetto.PiantaService.IPiantaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PiantaServiceClient : System.ServiceModel.ClientBase<Progetto.PiantaService.IPiantaService>, Progetto.PiantaService.IPiantaService {
        
        public PiantaServiceClient() {
        }
        
        public PiantaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PiantaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PiantaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PiantaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Progetto.PiantaService.pianta[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<Progetto.PiantaService.pianta[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public Progetto.PiantaService.pianta find(int id) {
            return base.Channel.find(id);
        }
        
        public System.Threading.Tasks.Task<Progetto.PiantaService.pianta> findAsync(int id) {
            return base.Channel.findAsync(id);
        }
        
        public void Addpianta(Progetto.PiantaService.pianta pianta) {
            base.Channel.Addpianta(pianta);
        }
        
        public System.Threading.Tasks.Task AddpiantaAsync(Progetto.PiantaService.pianta pianta) {
            return base.Channel.AddpiantaAsync(pianta);
        }
    }
}
