﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetDistributedClient.CalculatePointServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Straight", Namespace="http://CalculatePoint.org/")]
    [System.SerializableAttribute()]
    public partial class Straight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AspNetDistributedClient.CalculatePointServiceReference.Point FirstPointField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AspNetDistributedClient.CalculatePointServiceReference.Point SecondPointField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public AspNetDistributedClient.CalculatePointServiceReference.Point FirstPoint {
            get {
                return this.FirstPointField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstPointField, value) != true)) {
                    this.FirstPointField = value;
                    this.RaisePropertyChanged("FirstPoint");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public AspNetDistributedClient.CalculatePointServiceReference.Point SecondPoint {
            get {
                return this.SecondPointField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondPointField, value) != true)) {
                    this.SecondPointField = value;
                    this.RaisePropertyChanged("SecondPoint");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Point", Namespace="http://CalculatePoint.org/")]
    [System.SerializableAttribute()]
    public partial class Point : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private float XField;
        
        private float YField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public float X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public float Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://CalculatePoint.org/", ConfigurationName="CalculatePointServiceReference.CalculatePointSoap")]
    public interface CalculatePointSoap {
        
        // CODEGEN: Generating message contract since element name FirstStraight from namespace http://CalculatePoint.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://CalculatePoint.org/CalculateIntersection", ReplyAction="*")]
        AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionResponse CalculateIntersection(AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CalculatePoint.org/CalculateIntersection", ReplyAction="*")]
        System.Threading.Tasks.Task<AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionResponse> CalculateIntersectionAsync(AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateIntersectionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateIntersection", Namespace="http://CalculatePoint.org/", Order=0)]
        public AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequestBody Body;
        
        public CalculateIntersectionRequest() {
        }
        
        public CalculateIntersectionRequest(AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://CalculatePoint.org/")]
    public partial class CalculateIntersectionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AspNetDistributedClient.CalculatePointServiceReference.Straight FirstStraight;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public AspNetDistributedClient.CalculatePointServiceReference.Straight SecondStraight;
        
        public CalculateIntersectionRequestBody() {
        }
        
        public CalculateIntersectionRequestBody(AspNetDistributedClient.CalculatePointServiceReference.Straight FirstStraight, AspNetDistributedClient.CalculatePointServiceReference.Straight SecondStraight) {
            this.FirstStraight = FirstStraight;
            this.SecondStraight = SecondStraight;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateIntersectionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateIntersectionResponse", Namespace="http://CalculatePoint.org/", Order=0)]
        public AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionResponseBody Body;
        
        public CalculateIntersectionResponse() {
        }
        
        public CalculateIntersectionResponse(AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://CalculatePoint.org/")]
    public partial class CalculateIntersectionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AspNetDistributedClient.CalculatePointServiceReference.Point CalculateIntersectionResult;
        
        public CalculateIntersectionResponseBody() {
        }
        
        public CalculateIntersectionResponseBody(AspNetDistributedClient.CalculatePointServiceReference.Point CalculateIntersectionResult) {
            this.CalculateIntersectionResult = CalculateIntersectionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatePointSoapChannel : AspNetDistributedClient.CalculatePointServiceReference.CalculatePointSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatePointSoapClient : System.ServiceModel.ClientBase<AspNetDistributedClient.CalculatePointServiceReference.CalculatePointSoap>, AspNetDistributedClient.CalculatePointServiceReference.CalculatePointSoap {
        
        public CalculatePointSoapClient() {
        }
        
        public CalculatePointSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatePointSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatePointSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatePointSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionResponse AspNetDistributedClient.CalculatePointServiceReference.CalculatePointSoap.CalculateIntersection(AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequest request) {
            return base.Channel.CalculateIntersection(request);
        }
        
        public AspNetDistributedClient.CalculatePointServiceReference.Point CalculateIntersection(AspNetDistributedClient.CalculatePointServiceReference.Straight FirstStraight, AspNetDistributedClient.CalculatePointServiceReference.Straight SecondStraight) {
            AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequest inValue = new AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequest();
            inValue.Body = new AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequestBody();
            inValue.Body.FirstStraight = FirstStraight;
            inValue.Body.SecondStraight = SecondStraight;
            AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionResponse retVal = ((AspNetDistributedClient.CalculatePointServiceReference.CalculatePointSoap)(this)).CalculateIntersection(inValue);
            return retVal.Body.CalculateIntersectionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionResponse> AspNetDistributedClient.CalculatePointServiceReference.CalculatePointSoap.CalculateIntersectionAsync(AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequest request) {
            return base.Channel.CalculateIntersectionAsync(request);
        }
        
        public System.Threading.Tasks.Task<AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionResponse> CalculateIntersectionAsync(AspNetDistributedClient.CalculatePointServiceReference.Straight FirstStraight, AspNetDistributedClient.CalculatePointServiceReference.Straight SecondStraight) {
            AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequest inValue = new AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequest();
            inValue.Body = new AspNetDistributedClient.CalculatePointServiceReference.CalculateIntersectionRequestBody();
            inValue.Body.FirstStraight = FirstStraight;
            inValue.Body.SecondStraight = SecondStraight;
            return ((AspNetDistributedClient.CalculatePointServiceReference.CalculatePointSoap)(this)).CalculateIntersectionAsync(inValue);
        }
    }
}
