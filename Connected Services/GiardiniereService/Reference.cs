﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Progetto.GiardiniereService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="giardiniere", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class giardiniere : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MATgiardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cognomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
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
        public int MATgiard {
            get {
                return this.MATgiardField;
            }
            set {
                if ((this.MATgiardField.Equals(value) != true)) {
                    this.MATgiardField = value;
                    this.RaisePropertyChanged("MATgiard");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cognome {
            get {
                return this.cognomeField;
            }
            set {
                if ((object.ReferenceEquals(this.cognomeField, value) != true)) {
                    this.cognomeField = value;
                    this.RaisePropertyChanged("cognome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GiardiniereService.IGiardiniereService")]
    public interface IGiardiniereService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiardiniereService/findAll", ReplyAction="http://tempuri.org/IGiardiniereService/findAllResponse")]
        Progetto.GiardiniereService.giardiniere[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiardiniereService/findAll", ReplyAction="http://tempuri.org/IGiardiniereService/findAllResponse")]
        System.Threading.Tasks.Task<Progetto.GiardiniereService.giardiniere[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiardiniereService/find", ReplyAction="http://tempuri.org/IGiardiniereService/findResponse")]
        Progetto.GiardiniereService.giardiniere find(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiardiniereService/find", ReplyAction="http://tempuri.org/IGiardiniereService/findResponse")]
        System.Threading.Tasks.Task<Progetto.GiardiniereService.giardiniere> findAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiardiniereService/Addgiard", ReplyAction="http://tempuri.org/IGiardiniereService/AddgiardResponse")]
        void Addgiard(Progetto.GiardiniereService.giardiniere giard);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiardiniereService/Addgiard", ReplyAction="http://tempuri.org/IGiardiniereService/AddgiardResponse")]
        System.Threading.Tasks.Task AddgiardAsync(Progetto.GiardiniereService.giardiniere giard);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiardiniereService/visemail", ReplyAction="http://tempuri.org/IGiardiniereService/visemailResponse")]
        bool visemail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGiardiniereService/visemail", ReplyAction="http://tempuri.org/IGiardiniereService/visemailResponse")]
        System.Threading.Tasks.Task<bool> visemailAsync(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGiardiniereServiceChannel : Progetto.GiardiniereService.IGiardiniereService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GiardiniereServiceClient : System.ServiceModel.ClientBase<Progetto.GiardiniereService.IGiardiniereService>, Progetto.GiardiniereService.IGiardiniereService {
        
        public GiardiniereServiceClient() {
        }
        
        public GiardiniereServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GiardiniereServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GiardiniereServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GiardiniereServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Progetto.GiardiniereService.giardiniere[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<Progetto.GiardiniereService.giardiniere[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public Progetto.GiardiniereService.giardiniere find(int id) {
            return base.Channel.find(id);
        }
        
        public System.Threading.Tasks.Task<Progetto.GiardiniereService.giardiniere> findAsync(int id) {
            return base.Channel.findAsync(id);
        }
        
        public void Addgiard(Progetto.GiardiniereService.giardiniere giard) {
            base.Channel.Addgiard(giard);
        }
        
        public System.Threading.Tasks.Task AddgiardAsync(Progetto.GiardiniereService.giardiniere giard) {
            return base.Channel.AddgiardAsync(giard);
        }
        
        public bool visemail(string email) {
            return base.Channel.visemail(email);
        }
        
        public System.Threading.Tasks.Task<bool> visemailAsync(string email) {
            return base.Channel.visemailAsync(email);
        }
    }
}
