﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersistentEntity", Namespace="http://tempuri.org/")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StoreServiceReference.Brand))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StoreServiceReference.Product))]
    public partial class PersistentEntity : object
    {
        
        private string IdField;
        
        private int ObjectIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ObjectId
        {
            get
            {
                return this.ObjectIdField;
            }
            set
            {
                this.ObjectIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Brand", Namespace="http://tempuri.org/")]
    public partial class Brand : StoreServiceReference.PersistentEntity
    {
        
        private string NameField;
        
        private string WebsiteField;
        
        private string LogoURLField;
        
        private string DescriptionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Website
        {
            get
            {
                return this.WebsiteField;
            }
            set
            {
                this.WebsiteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string LogoURL
        {
            get
            {
                return this.LogoURLField;
            }
            set
            {
                this.LogoURLField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://tempuri.org/")]
    public partial class Product : StoreServiceReference.PersistentEntity
    {
        
        private StoreServiceReference.ProductInfo ProductInfoField;
        
        private int StockField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public StoreServiceReference.ProductInfo ProductInfo
        {
            get
            {
                return this.ProductInfoField;
            }
            set
            {
                this.ProductInfoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Stock
        {
            get
            {
                return this.StockField;
            }
            set
            {
                this.StockField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductInfo", Namespace="http://tempuri.org/")]
    public partial class ProductInfo : object
    {
        
        private string NameField;
        
        private StoreServiceReference.ProductCategory CategoryField;
        
        private decimal PriceField;
        
        private short RatingField;
        
        private StoreServiceReference.Brand BrandField;
        
        private string DescriptionField;
        
        private StoreServiceReference.ArrayOfString SpecificationsField;
        
        private string ShortDescriptionField;
        
        private string MainImageURLField;
        
        private StoreServiceReference.ArrayOfString ImageURLsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public StoreServiceReference.ProductCategory Category
        {
            get
            {
                return this.CategoryField;
            }
            set
            {
                this.CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public decimal Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public short Rating
        {
            get
            {
                return this.RatingField;
            }
            set
            {
                this.RatingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public StoreServiceReference.Brand Brand
        {
            get
            {
                return this.BrandField;
            }
            set
            {
                this.BrandField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public StoreServiceReference.ArrayOfString Specifications
        {
            get
            {
                return this.SpecificationsField;
            }
            set
            {
                this.SpecificationsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string ShortDescription
        {
            get
            {
                return this.ShortDescriptionField;
            }
            set
            {
                this.ShortDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string MainImageURL
        {
            get
            {
                return this.MainImageURLField;
            }
            set
            {
                this.MainImageURLField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public StoreServiceReference.ArrayOfString ImageURLs
        {
            get
            {
                return this.ImageURLsField;
            }
            set
            {
                this.ImageURLsField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductCategory", Namespace="http://tempuri.org/")]
    public enum ProductCategory : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Components = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BuiltPC = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Notebook = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Peripheral = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    public class ArrayOfString : System.Collections.Generic.List<string>
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StoreServiceReference.StoreServiceSoap")]
    public interface StoreServiceSoap
    {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetProductByIdResult del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductById", ReplyAction="*")]
        StoreServiceReference.GetProductByIdResponse GetProductById(StoreServiceReference.GetProductByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductById", ReplyAction="*")]
        System.Threading.Tasks.Task<StoreServiceReference.GetProductByIdResponse> GetProductByIdAsync(StoreServiceReference.GetProductByIdRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetProductsByCategoryResult del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductsByCategory", ReplyAction="*")]
        StoreServiceReference.GetProductsByCategoryResponse GetProductsByCategory(StoreServiceReference.GetProductsByCategoryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProductsByCategory", ReplyAction="*")]
        System.Threading.Tasks.Task<StoreServiceReference.GetProductsByCategoryResponse> GetProductsByCategoryAsync(StoreServiceReference.GetProductsByCategoryRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetAllProductsResult del espacio de nombres http://tempuri.org/ no está marcado para convertirse en valor nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllProducts", ReplyAction="*")]
        StoreServiceReference.GetAllProductsResponse GetAllProducts(StoreServiceReference.GetAllProductsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllProducts", ReplyAction="*")]
        System.Threading.Tasks.Task<StoreServiceReference.GetAllProductsResponse> GetAllProductsAsync(StoreServiceReference.GetAllProductsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductByIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductById", Namespace="http://tempuri.org/", Order=0)]
        public StoreServiceReference.GetProductByIdRequestBody Body;
        
        public GetProductByIdRequest()
        {
        }
        
        public GetProductByIdRequest(StoreServiceReference.GetProductByIdRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductByIdRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetProductByIdRequestBody()
        {
        }
        
        public GetProductByIdRequestBody(int id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductByIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductByIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public StoreServiceReference.GetProductByIdResponseBody Body;
        
        public GetProductByIdResponse()
        {
        }
        
        public GetProductByIdResponse(StoreServiceReference.GetProductByIdResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductByIdResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public StoreServiceReference.Product GetProductByIdResult;
        
        public GetProductByIdResponseBody()
        {
        }
        
        public GetProductByIdResponseBody(StoreServiceReference.Product GetProductByIdResult)
        {
            this.GetProductByIdResult = GetProductByIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsByCategoryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsByCategory", Namespace="http://tempuri.org/", Order=0)]
        public StoreServiceReference.GetProductsByCategoryRequestBody Body;
        
        public GetProductsByCategoryRequest()
        {
        }
        
        public GetProductsByCategoryRequest(StoreServiceReference.GetProductsByCategoryRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsByCategoryRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public StoreServiceReference.ProductCategory category;
        
        public GetProductsByCategoryRequestBody()
        {
        }
        
        public GetProductsByCategoryRequestBody(StoreServiceReference.ProductCategory category)
        {
            this.category = category;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsByCategoryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsByCategoryResponse", Namespace="http://tempuri.org/", Order=0)]
        public StoreServiceReference.GetProductsByCategoryResponseBody Body;
        
        public GetProductsByCategoryResponse()
        {
        }
        
        public GetProductsByCategoryResponse(StoreServiceReference.GetProductsByCategoryResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsByCategoryResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public StoreServiceReference.Product[] GetProductsByCategoryResult;
        
        public GetProductsByCategoryResponseBody()
        {
        }
        
        public GetProductsByCategoryResponseBody(StoreServiceReference.Product[] GetProductsByCategoryResult)
        {
            this.GetProductsByCategoryResult = GetProductsByCategoryResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllProductsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllProducts", Namespace="http://tempuri.org/", Order=0)]
        public StoreServiceReference.GetAllProductsRequestBody Body;
        
        public GetAllProductsRequest()
        {
        }
        
        public GetAllProductsRequest(StoreServiceReference.GetAllProductsRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllProductsRequestBody
    {
        
        public GetAllProductsRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllProductsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllProductsResponse", Namespace="http://tempuri.org/", Order=0)]
        public StoreServiceReference.GetAllProductsResponseBody Body;
        
        public GetAllProductsResponse()
        {
        }
        
        public GetAllProductsResponse(StoreServiceReference.GetAllProductsResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllProductsResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public StoreServiceReference.Product[] GetAllProductsResult;
        
        public GetAllProductsResponseBody()
        {
        }
        
        public GetAllProductsResponseBody(StoreServiceReference.Product[] GetAllProductsResult)
        {
            this.GetAllProductsResult = GetAllProductsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface StoreServiceSoapChannel : StoreServiceReference.StoreServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class StoreServiceSoapClient : System.ServiceModel.ClientBase<StoreServiceReference.StoreServiceSoap>, StoreServiceReference.StoreServiceSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public StoreServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(StoreServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), StoreServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StoreServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(StoreServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StoreServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(StoreServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StoreServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StoreServiceReference.GetProductByIdResponse StoreServiceReference.StoreServiceSoap.GetProductById(StoreServiceReference.GetProductByIdRequest request)
        {
            return base.Channel.GetProductById(request);
        }
        
        public StoreServiceReference.Product GetProductById(int id)
        {
            StoreServiceReference.GetProductByIdRequest inValue = new StoreServiceReference.GetProductByIdRequest();
            inValue.Body = new StoreServiceReference.GetProductByIdRequestBody();
            inValue.Body.id = id;
            StoreServiceReference.GetProductByIdResponse retVal = ((StoreServiceReference.StoreServiceSoap)(this)).GetProductById(inValue);
            return retVal.Body.GetProductByIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StoreServiceReference.GetProductByIdResponse> StoreServiceReference.StoreServiceSoap.GetProductByIdAsync(StoreServiceReference.GetProductByIdRequest request)
        {
            return base.Channel.GetProductByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<StoreServiceReference.GetProductByIdResponse> GetProductByIdAsync(int id)
        {
            StoreServiceReference.GetProductByIdRequest inValue = new StoreServiceReference.GetProductByIdRequest();
            inValue.Body = new StoreServiceReference.GetProductByIdRequestBody();
            inValue.Body.id = id;
            return ((StoreServiceReference.StoreServiceSoap)(this)).GetProductByIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StoreServiceReference.GetProductsByCategoryResponse StoreServiceReference.StoreServiceSoap.GetProductsByCategory(StoreServiceReference.GetProductsByCategoryRequest request)
        {
            return base.Channel.GetProductsByCategory(request);
        }
        
        public StoreServiceReference.Product[] GetProductsByCategory(StoreServiceReference.ProductCategory category)
        {
            StoreServiceReference.GetProductsByCategoryRequest inValue = new StoreServiceReference.GetProductsByCategoryRequest();
            inValue.Body = new StoreServiceReference.GetProductsByCategoryRequestBody();
            inValue.Body.category = category;
            StoreServiceReference.GetProductsByCategoryResponse retVal = ((StoreServiceReference.StoreServiceSoap)(this)).GetProductsByCategory(inValue);
            return retVal.Body.GetProductsByCategoryResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StoreServiceReference.GetProductsByCategoryResponse> StoreServiceReference.StoreServiceSoap.GetProductsByCategoryAsync(StoreServiceReference.GetProductsByCategoryRequest request)
        {
            return base.Channel.GetProductsByCategoryAsync(request);
        }
        
        public System.Threading.Tasks.Task<StoreServiceReference.GetProductsByCategoryResponse> GetProductsByCategoryAsync(StoreServiceReference.ProductCategory category)
        {
            StoreServiceReference.GetProductsByCategoryRequest inValue = new StoreServiceReference.GetProductsByCategoryRequest();
            inValue.Body = new StoreServiceReference.GetProductsByCategoryRequestBody();
            inValue.Body.category = category;
            return ((StoreServiceReference.StoreServiceSoap)(this)).GetProductsByCategoryAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StoreServiceReference.GetAllProductsResponse StoreServiceReference.StoreServiceSoap.GetAllProducts(StoreServiceReference.GetAllProductsRequest request)
        {
            return base.Channel.GetAllProducts(request);
        }
        
        public StoreServiceReference.Product[] GetAllProducts()
        {
            StoreServiceReference.GetAllProductsRequest inValue = new StoreServiceReference.GetAllProductsRequest();
            inValue.Body = new StoreServiceReference.GetAllProductsRequestBody();
            StoreServiceReference.GetAllProductsResponse retVal = ((StoreServiceReference.StoreServiceSoap)(this)).GetAllProducts(inValue);
            return retVal.Body.GetAllProductsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StoreServiceReference.GetAllProductsResponse> StoreServiceReference.StoreServiceSoap.GetAllProductsAsync(StoreServiceReference.GetAllProductsRequest request)
        {
            return base.Channel.GetAllProductsAsync(request);
        }
        
        public System.Threading.Tasks.Task<StoreServiceReference.GetAllProductsResponse> GetAllProductsAsync()
        {
            StoreServiceReference.GetAllProductsRequest inValue = new StoreServiceReference.GetAllProductsRequest();
            inValue.Body = new StoreServiceReference.GetAllProductsRequestBody();
            return ((StoreServiceReference.StoreServiceSoap)(this)).GetAllProductsAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.StoreServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.StoreServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.StoreServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44321/Services/StoreService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.StoreServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44321/Services/StoreService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            StoreServiceSoap,
            
            StoreServiceSoap12,
        }
    }
}
