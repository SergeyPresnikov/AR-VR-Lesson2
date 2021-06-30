﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCompany.Communication.MyCopmanyService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecondNameField;
        
        private MyCompany.Communication.MyCopmanyService.DepartmentCategory CategoryField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string SecondName {
            get {
                return this.SecondNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondNameField, value) != true)) {
                    this.SecondNameField = value;
                    this.RaisePropertyChanged("SecondName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public MyCompany.Communication.MyCopmanyService.DepartmentCategory Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((this.CategoryField.Equals(value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentCategory", Namespace="http://tempuri.org/")]
    public enum DepartmentCategory : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Терапевтическое = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Неврологическое = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Инфекционное = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Урологическое = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Хирургическое = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyCopmanyService.MyCompanyServiceSoap")]
    public interface MyCompanyServiceSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем LoadResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Load", ReplyAction="*")]
        MyCompany.Communication.MyCopmanyService.LoadResponse Load(MyCompany.Communication.MyCopmanyService.LoadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Load", ReplyAction="*")]
        System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.LoadResponse> LoadAsync(MyCompany.Communication.MyCopmanyService.LoadRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем employee из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        MyCompany.Communication.MyCopmanyService.AddResponse Add(MyCompany.Communication.MyCopmanyService.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.AddResponse> AddAsync(MyCompany.Communication.MyCopmanyService.AddRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем employee из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        MyCompany.Communication.MyCopmanyService.UpdateResponse Update(MyCompany.Communication.MyCopmanyService.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.UpdateResponse> UpdateAsync(MyCompany.Communication.MyCopmanyService.UpdateRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем employee из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Remove", ReplyAction="*")]
        MyCompany.Communication.MyCopmanyService.RemoveResponse Remove(MyCompany.Communication.MyCopmanyService.RemoveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Remove", ReplyAction="*")]
        System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.RemoveResponse> RemoveAsync(MyCompany.Communication.MyCopmanyService.RemoveRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Load", Namespace="http://tempuri.org/", Order=0)]
        public MyCompany.Communication.MyCopmanyService.LoadRequestBody Body;
        
        public LoadRequest() {
        }
        
        public LoadRequest(MyCompany.Communication.MyCopmanyService.LoadRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class LoadRequestBody {
        
        public LoadRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoadResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyCompany.Communication.MyCopmanyService.LoadResponseBody Body;
        
        public LoadResponse() {
        }
        
        public LoadResponse(MyCompany.Communication.MyCopmanyService.LoadResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoadResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyCompany.Communication.MyCopmanyService.Employee[] LoadResult;
        
        public LoadResponseBody() {
        }
        
        public LoadResponseBody(MyCompany.Communication.MyCopmanyService.Employee[] LoadResult) {
            this.LoadResult = LoadResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public MyCompany.Communication.MyCopmanyService.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(MyCompany.Communication.MyCopmanyService.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyCompany.Communication.MyCopmanyService.Employee employee;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(MyCompany.Communication.MyCopmanyService.Employee employee) {
            this.employee = employee;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyCompany.Communication.MyCopmanyService.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(MyCompany.Communication.MyCopmanyService.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddResult;
        
        public AddResponseBody() {
        }
        
        public AddResponseBody(int AddResult) {
            this.AddResult = AddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public MyCompany.Communication.MyCopmanyService.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(MyCompany.Communication.MyCopmanyService.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyCompany.Communication.MyCopmanyService.Employee employee;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(MyCompany.Communication.MyCopmanyService.Employee employee) {
            this.employee = employee;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyCompany.Communication.MyCopmanyService.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(MyCompany.Communication.MyCopmanyService.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UpdateResult;
        
        public UpdateResponseBody() {
        }
        
        public UpdateResponseBody(int UpdateResult) {
            this.UpdateResult = UpdateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemoveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Remove", Namespace="http://tempuri.org/", Order=0)]
        public MyCompany.Communication.MyCopmanyService.RemoveRequestBody Body;
        
        public RemoveRequest() {
        }
        
        public RemoveRequest(MyCompany.Communication.MyCopmanyService.RemoveRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RemoveRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyCompany.Communication.MyCopmanyService.Employee employee;
        
        public RemoveRequestBody() {
        }
        
        public RemoveRequestBody(MyCompany.Communication.MyCopmanyService.Employee employee) {
            this.employee = employee;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemoveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemoveResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyCompany.Communication.MyCopmanyService.RemoveResponseBody Body;
        
        public RemoveResponse() {
        }
        
        public RemoveResponse(MyCompany.Communication.MyCopmanyService.RemoveResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RemoveResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int RemoveResult;
        
        public RemoveResponseBody() {
        }
        
        public RemoveResponseBody(int RemoveResult) {
            this.RemoveResult = RemoveResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyCompanyServiceSoapChannel : MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyCompanyServiceSoapClient : System.ServiceModel.ClientBase<MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap>, MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap {
        
        public MyCompanyServiceSoapClient() {
        }
        
        public MyCompanyServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyCompanyServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCompanyServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCompanyServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyCompany.Communication.MyCopmanyService.LoadResponse MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap.Load(MyCompany.Communication.MyCopmanyService.LoadRequest request) {
            return base.Channel.Load(request);
        }
        
        public MyCompany.Communication.MyCopmanyService.Employee[] Load() {
            MyCompany.Communication.MyCopmanyService.LoadRequest inValue = new MyCompany.Communication.MyCopmanyService.LoadRequest();
            inValue.Body = new MyCompany.Communication.MyCopmanyService.LoadRequestBody();
            MyCompany.Communication.MyCopmanyService.LoadResponse retVal = ((MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap)(this)).Load(inValue);
            return retVal.Body.LoadResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.LoadResponse> MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap.LoadAsync(MyCompany.Communication.MyCopmanyService.LoadRequest request) {
            return base.Channel.LoadAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.LoadResponse> LoadAsync() {
            MyCompany.Communication.MyCopmanyService.LoadRequest inValue = new MyCompany.Communication.MyCopmanyService.LoadRequest();
            inValue.Body = new MyCompany.Communication.MyCopmanyService.LoadRequestBody();
            return ((MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap)(this)).LoadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyCompany.Communication.MyCopmanyService.AddResponse MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap.Add(MyCompany.Communication.MyCopmanyService.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public int Add(MyCompany.Communication.MyCopmanyService.Employee employee) {
            MyCompany.Communication.MyCopmanyService.AddRequest inValue = new MyCompany.Communication.MyCopmanyService.AddRequest();
            inValue.Body = new MyCompany.Communication.MyCopmanyService.AddRequestBody();
            inValue.Body.employee = employee;
            MyCompany.Communication.MyCopmanyService.AddResponse retVal = ((MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap)(this)).Add(inValue);
            return retVal.Body.AddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.AddResponse> MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap.AddAsync(MyCompany.Communication.MyCopmanyService.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.AddResponse> AddAsync(MyCompany.Communication.MyCopmanyService.Employee employee) {
            MyCompany.Communication.MyCopmanyService.AddRequest inValue = new MyCompany.Communication.MyCopmanyService.AddRequest();
            inValue.Body = new MyCompany.Communication.MyCopmanyService.AddRequestBody();
            inValue.Body.employee = employee;
            return ((MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap)(this)).AddAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyCompany.Communication.MyCopmanyService.UpdateResponse MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap.Update(MyCompany.Communication.MyCopmanyService.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public int Update(MyCompany.Communication.MyCopmanyService.Employee employee) {
            MyCompany.Communication.MyCopmanyService.UpdateRequest inValue = new MyCompany.Communication.MyCopmanyService.UpdateRequest();
            inValue.Body = new MyCompany.Communication.MyCopmanyService.UpdateRequestBody();
            inValue.Body.employee = employee;
            MyCompany.Communication.MyCopmanyService.UpdateResponse retVal = ((MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap)(this)).Update(inValue);
            return retVal.Body.UpdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.UpdateResponse> MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap.UpdateAsync(MyCompany.Communication.MyCopmanyService.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.UpdateResponse> UpdateAsync(MyCompany.Communication.MyCopmanyService.Employee employee) {
            MyCompany.Communication.MyCopmanyService.UpdateRequest inValue = new MyCompany.Communication.MyCopmanyService.UpdateRequest();
            inValue.Body = new MyCompany.Communication.MyCopmanyService.UpdateRequestBody();
            inValue.Body.employee = employee;
            return ((MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap)(this)).UpdateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyCompany.Communication.MyCopmanyService.RemoveResponse MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap.Remove(MyCompany.Communication.MyCopmanyService.RemoveRequest request) {
            return base.Channel.Remove(request);
        }
        
        public int Remove(MyCompany.Communication.MyCopmanyService.Employee employee) {
            MyCompany.Communication.MyCopmanyService.RemoveRequest inValue = new MyCompany.Communication.MyCopmanyService.RemoveRequest();
            inValue.Body = new MyCompany.Communication.MyCopmanyService.RemoveRequestBody();
            inValue.Body.employee = employee;
            MyCompany.Communication.MyCopmanyService.RemoveResponse retVal = ((MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap)(this)).Remove(inValue);
            return retVal.Body.RemoveResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.RemoveResponse> MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap.RemoveAsync(MyCompany.Communication.MyCopmanyService.RemoveRequest request) {
            return base.Channel.RemoveAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyCompany.Communication.MyCopmanyService.RemoveResponse> RemoveAsync(MyCompany.Communication.MyCopmanyService.Employee employee) {
            MyCompany.Communication.MyCopmanyService.RemoveRequest inValue = new MyCompany.Communication.MyCopmanyService.RemoveRequest();
            inValue.Body = new MyCompany.Communication.MyCopmanyService.RemoveRequestBody();
            inValue.Body.employee = employee;
            return ((MyCompany.Communication.MyCopmanyService.MyCompanyServiceSoap)(this)).RemoveAsync(inValue);
        }
    }
}
