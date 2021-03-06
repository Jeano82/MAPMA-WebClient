﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MAPMA_WebClient.CusRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MAPMA_WebClient.CusRef.Customer))]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
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
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mail {
            get {
                return this.mailField;
            }
            set {
                if ((object.ReferenceEquals(this.mailField, value) != true)) {
                    this.mailField = value;
                    this.RaisePropertyChanged("mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Customer : MAPMA_WebClient.CusRef.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int customerNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int customerNo {
            get {
                return this.customerNoField;
            }
            set {
                if ((this.customerNoField.Equals(value) != true)) {
                    this.customerNoField = value;
                    this.RaisePropertyChanged("customerNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8737/Design_Time_Addresses/Customer/", ConfigurationName="CusRef.ICustomerServices")]
    public interface ICustomerServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8737/Design_Time_Addresses/Customer/ICustomerServices/Get", ReplyAction="http://localhost:8737/Design_Time_Addresses/Customer/ICustomerServices/GetRespons" +
            "e")]
        MAPMA_WebClient.CusRef.Customer Get(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8737/Design_Time_Addresses/Customer/ICustomerServices/Get", ReplyAction="http://localhost:8737/Design_Time_Addresses/Customer/ICustomerServices/GetRespons" +
            "e")]
        System.Threading.Tasks.Task<MAPMA_WebClient.CusRef.Customer> GetAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServicesChannel : MAPMA_WebClient.CusRef.ICustomerServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServicesClient : System.ServiceModel.ClientBase<MAPMA_WebClient.CusRef.ICustomerServices>, MAPMA_WebClient.CusRef.ICustomerServices {
        
        public CustomerServicesClient() {
        }
        
        public CustomerServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MAPMA_WebClient.CusRef.Customer Get(string username) {
            return base.Channel.Get(username);
        }
        
        public System.Threading.Tasks.Task<MAPMA_WebClient.CusRef.Customer> GetAsync(string username) {
            return base.Channel.GetAsync(username);
        }
    }
}
