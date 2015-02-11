﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageCenterWebClient.MessageService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/MessageClassLibrary")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageBodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime MessageTimeField;
        
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
        public string MessageBody {
            get {
                return this.MessageBodyField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageBodyField, value) != true)) {
                    this.MessageBodyField = value;
                    this.RaisePropertyChanged("MessageBody");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MessageID {
            get {
                return this.MessageIDField;
            }
            set {
                if ((this.MessageIDField.Equals(value) != true)) {
                    this.MessageIDField = value;
                    this.RaisePropertyChanged("MessageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime MessageTime {
            get {
                return this.MessageTimeField;
            }
            set {
                if ((this.MessageTimeField.Equals(value) != true)) {
                    this.MessageTimeField = value;
                    this.RaisePropertyChanged("MessageTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MessageService.IMessageService")]
    public interface IMessageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/InsertMessage", ReplyAction="http://tempuri.org/IMessageService/InsertMessageResponse")]
        bool InsertMessage(MessageCenterWebClient.MessageService.Message obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/InsertMessage", ReplyAction="http://tempuri.org/IMessageService/InsertMessageResponse")]
        System.Threading.Tasks.Task<bool> InsertMessageAsync(MessageCenterWebClient.MessageService.Message obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetAllMessage", ReplyAction="http://tempuri.org/IMessageService/GetAllMessageResponse")]
        MessageCenterWebClient.MessageService.Message[] GetAllMessage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetAllMessage", ReplyAction="http://tempuri.org/IMessageService/GetAllMessageResponse")]
        System.Threading.Tasks.Task<MessageCenterWebClient.MessageService.Message[]> GetAllMessageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageServiceChannel : MessageCenterWebClient.MessageService.IMessageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessageServiceClient : System.ServiceModel.ClientBase<MessageCenterWebClient.MessageService.IMessageService>, MessageCenterWebClient.MessageService.IMessageService {
        
        public MessageServiceClient() {
        }
        
        public MessageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MessageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MessageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MessageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool InsertMessage(MessageCenterWebClient.MessageService.Message obj) {
            return base.Channel.InsertMessage(obj);
        }
        
        public System.Threading.Tasks.Task<bool> InsertMessageAsync(MessageCenterWebClient.MessageService.Message obj) {
            return base.Channel.InsertMessageAsync(obj);
        }
        
        public MessageCenterWebClient.MessageService.Message[] GetAllMessage() {
            return base.Channel.GetAllMessage();
        }
        
        public System.Threading.Tasks.Task<MessageCenterWebClient.MessageService.Message[]> GetAllMessageAsync() {
            return base.Channel.GetAllMessageAsync();
        }
    }
}
