﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.AdminService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminService.IAdminService")]
    public interface IAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AdminLogin", ReplyAction="http://tempuri.org/IAdminService/AdminLoginResponse")]
        string AdminLogin(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/AdminLogin", ReplyAction="http://tempuri.org/IAdminService/AdminLoginResponse")]
        System.Threading.Tasks.Task<string> AdminLoginAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminServiceChannel : WebClient.AdminService.IAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminServiceClient : System.ServiceModel.ClientBase<WebClient.AdminService.IAdminService>, WebClient.AdminService.IAdminService {
        
        public AdminServiceClient() {
        }
        
        public AdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AdminLogin(string username, string password) {
            return base.Channel.AdminLogin(username, password);
        }
        
        public System.Threading.Tasks.Task<string> AdminLoginAsync(string username, string password) {
            return base.Channel.AdminLoginAsync(username, password);
        }
    }
}