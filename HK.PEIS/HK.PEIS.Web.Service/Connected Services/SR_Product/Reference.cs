﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HK.PEIS.Web.Service.SR_Product {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_Product.IProductWCFService")]
    public interface IProductWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductWCFService/GetAllProduct", ReplyAction="http://tempuri.org/IProductWCFService/GetAllProductResponse")]
        System.Collections.Generic.List<HK.PEIS.DTO.DTO_TP_PRODUCT> GetAllProduct();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductWCFService/GetAllProduct", ReplyAction="http://tempuri.org/IProductWCFService/GetAllProductResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<HK.PEIS.DTO.DTO_TP_PRODUCT>> GetAllProductAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductWCFServiceChannel : HK.PEIS.Web.Service.SR_Product.IProductWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductWCFServiceClient : System.ServiceModel.ClientBase<HK.PEIS.Web.Service.SR_Product.IProductWCFService>, HK.PEIS.Web.Service.SR_Product.IProductWCFService {
        
        public ProductWCFServiceClient() {
        }
        
        public ProductWCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductWCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductWCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductWCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<HK.PEIS.DTO.DTO_TP_PRODUCT> GetAllProduct() {
            return base.Channel.GetAllProduct();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<HK.PEIS.DTO.DTO_TP_PRODUCT>> GetAllProductAsync() {
            return base.Channel.GetAllProductAsync();
        }
    }
}