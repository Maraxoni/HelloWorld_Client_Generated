﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyNamespace
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyNamespace.IHelloWorld")]
    public interface IHelloWorld
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorld/GetHelloWorldAsString", ReplyAction="http://tempuri.org/IHelloWorld/GetHelloWorldAsStringResponse")]
        string GetHelloWorldAsString(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorld/GetHelloWorldAsString", ReplyAction="http://tempuri.org/IHelloWorld/GetHelloWorldAsStringResponse")]
        System.Threading.Tasks.Task<string> GetHelloWorldAsStringAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldChannel : MyNamespace.IHelloWorld, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldClient : System.ServiceModel.ClientBase<MyNamespace.IHelloWorld>, MyNamespace.IHelloWorld
    {
        
        public HelloWorldClient()
        {
        }
        
        //public HelloWorldClient(string endpointConfigurationName) : 
        //        base(endpointConfigurationName)
        //{
        //}
        
        //public HelloWorldClient(string endpointConfigurationName, string remoteAddress) : 
        //        base(endpointConfigurationName, remoteAddress)
        //{
        //}
        
        //public HelloWorldClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
        //        base(endpointConfigurationName, remoteAddress)
        //{
        //}
        
        public HelloWorldClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string GetHelloWorldAsString(string name)
        {
            return base.Channel.GetHelloWorldAsString(name);
        }
        
        public System.Threading.Tasks.Task<string> GetHelloWorldAsStringAsync(string name)
        {
            return base.Channel.GetHelloWorldAsStringAsync(name);
        }
    }
}
