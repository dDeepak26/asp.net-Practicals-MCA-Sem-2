﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorApplication.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.calculatorSoap")]
    public interface calculatorSoap {
        
        // CODEGEN: Generating message contract since element name operation from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Calculator1", ReplyAction="*")]
        CalculatorApplication.ServiceReference1.Calculator1Response Calculator1(CalculatorApplication.ServiceReference1.Calculator1Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Calculator1", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorApplication.ServiceReference1.Calculator1Response> Calculator1Async(CalculatorApplication.ServiceReference1.Calculator1Request request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Calculator1Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Calculator1", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorApplication.ServiceReference1.Calculator1RequestBody Body;
        
        public Calculator1Request() {
        }
        
        public Calculator1Request(CalculatorApplication.ServiceReference1.Calculator1RequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Calculator1RequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int firstvalue;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int secondvalue;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string operation;
        
        public Calculator1RequestBody() {
        }
        
        public Calculator1RequestBody(int firstvalue, int secondvalue, string operation) {
            this.firstvalue = firstvalue;
            this.secondvalue = secondvalue;
            this.operation = operation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Calculator1Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Calculator1Response", Namespace="http://tempuri.org/", Order=0)]
        public CalculatorApplication.ServiceReference1.Calculator1ResponseBody Body;
        
        public Calculator1Response() {
        }
        
        public Calculator1Response(CalculatorApplication.ServiceReference1.Calculator1ResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Calculator1ResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Calculator1Result;
        
        public Calculator1ResponseBody() {
        }
        
        public Calculator1ResponseBody(string Calculator1Result) {
            this.Calculator1Result = Calculator1Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface calculatorSoapChannel : CalculatorApplication.ServiceReference1.calculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class calculatorSoapClient : System.ServiceModel.ClientBase<CalculatorApplication.ServiceReference1.calculatorSoap>, CalculatorApplication.ServiceReference1.calculatorSoap {
        
        public calculatorSoapClient() {
        }
        
        public calculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public calculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public calculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public calculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorApplication.ServiceReference1.Calculator1Response CalculatorApplication.ServiceReference1.calculatorSoap.Calculator1(CalculatorApplication.ServiceReference1.Calculator1Request request) {
            return base.Channel.Calculator1(request);
        }
        
        public string Calculator1(int firstvalue, int secondvalue, string operation) {
            CalculatorApplication.ServiceReference1.Calculator1Request inValue = new CalculatorApplication.ServiceReference1.Calculator1Request();
            inValue.Body = new CalculatorApplication.ServiceReference1.Calculator1RequestBody();
            inValue.Body.firstvalue = firstvalue;
            inValue.Body.secondvalue = secondvalue;
            inValue.Body.operation = operation;
            CalculatorApplication.ServiceReference1.Calculator1Response retVal = ((CalculatorApplication.ServiceReference1.calculatorSoap)(this)).Calculator1(inValue);
            return retVal.Body.Calculator1Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorApplication.ServiceReference1.Calculator1Response> CalculatorApplication.ServiceReference1.calculatorSoap.Calculator1Async(CalculatorApplication.ServiceReference1.Calculator1Request request) {
            return base.Channel.Calculator1Async(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorApplication.ServiceReference1.Calculator1Response> Calculator1Async(int firstvalue, int secondvalue, string operation) {
            CalculatorApplication.ServiceReference1.Calculator1Request inValue = new CalculatorApplication.ServiceReference1.Calculator1Request();
            inValue.Body = new CalculatorApplication.ServiceReference1.Calculator1RequestBody();
            inValue.Body.firstvalue = firstvalue;
            inValue.Body.secondvalue = secondvalue;
            inValue.Body.operation = operation;
            return ((CalculatorApplication.ServiceReference1.calculatorSoap)(this)).Calculator1Async(inValue);
        }
    }
}
