﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.AttendanceService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Attendance", Namespace="http://schemas.datacontract.org/2004/07/WcfServices.AttendanceService")]
    [System.SerializableAttribute()]
    public partial class Attendance : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PresentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebClient.AttendanceService.Student SField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebClient.AttendanceService.Teacher TField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Present {
            get {
                return this.PresentField;
            }
            set {
                if ((this.PresentField.Equals(value) != true)) {
                    this.PresentField = value;
                    this.RaisePropertyChanged("Present");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebClient.AttendanceService.Student S {
            get {
                return this.SField;
            }
            set {
                if ((object.ReferenceEquals(this.SField, value) != true)) {
                    this.SField = value;
                    this.RaisePropertyChanged("S");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebClient.AttendanceService.Teacher T {
            get {
                return this.TField;
            }
            set {
                if ((object.ReferenceEquals(this.TField, value) != true)) {
                    this.TField = value;
                    this.RaisePropertyChanged("T");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WcfServices.StudentService")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RollNoField;
        
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
        public int Class {
            get {
                return this.ClassField;
            }
            set {
                if ((this.ClassField.Equals(value) != true)) {
                    this.ClassField = value;
                    this.RaisePropertyChanged("Class");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RollNo {
            get {
                return this.RollNoField;
            }
            set {
                if ((this.RollNoField.Equals(value) != true)) {
                    this.RollNoField = value;
                    this.RaisePropertyChanged("RollNo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Teacher", Namespace="http://schemas.datacontract.org/2004/07/WcfServices.TeacherService")]
    [System.SerializableAttribute()]
    public partial class Teacher : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClassField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
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
        public int Class {
            get {
                return this.ClassField;
            }
            set {
                if ((this.ClassField.Equals(value) != true)) {
                    this.ClassField = value;
                    this.RaisePropertyChanged("Class");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AttendanceService.IAttendanceService")]
    public interface IAttendanceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/AddAttendances", ReplyAction="http://tempuri.org/IAttendanceService/AddAttendancesResponse")]
        string AddAttendances(int[] sids, bool[] presents, int tid, System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/AddAttendances", ReplyAction="http://tempuri.org/IAttendanceService/AddAttendancesResponse")]
        System.Threading.Tasks.Task<string> AddAttendancesAsync(int[] sids, bool[] presents, int tid, System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/GetAllAttendanceByTeacherAndDate", ReplyAction="http://tempuri.org/IAttendanceService/GetAllAttendanceByTeacherAndDateResponse")]
        WebClient.AttendanceService.Attendance[] GetAllAttendanceByTeacherAndDate(int tid, System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/GetAllAttendanceByTeacherAndDate", ReplyAction="http://tempuri.org/IAttendanceService/GetAllAttendanceByTeacherAndDateResponse")]
        System.Threading.Tasks.Task<WebClient.AttendanceService.Attendance[]> GetAllAttendanceByTeacherAndDateAsync(int tid, System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/GetAllAttendanceByStudentAndTeacher", ReplyAction="http://tempuri.org/IAttendanceService/GetAllAttendanceByStudentAndTeacherResponse" +
            "")]
        WebClient.AttendanceService.Attendance[] GetAllAttendanceByStudentAndTeacher(int sid, int tid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttendanceService/GetAllAttendanceByStudentAndTeacher", ReplyAction="http://tempuri.org/IAttendanceService/GetAllAttendanceByStudentAndTeacherResponse" +
            "")]
        System.Threading.Tasks.Task<WebClient.AttendanceService.Attendance[]> GetAllAttendanceByStudentAndTeacherAsync(int sid, int tid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAttendanceServiceChannel : WebClient.AttendanceService.IAttendanceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AttendanceServiceClient : System.ServiceModel.ClientBase<WebClient.AttendanceService.IAttendanceService>, WebClient.AttendanceService.IAttendanceService {
        
        public AttendanceServiceClient() {
        }
        
        public AttendanceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AttendanceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AttendanceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AttendanceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddAttendances(int[] sids, bool[] presents, int tid, System.DateTime dt) {
            return base.Channel.AddAttendances(sids, presents, tid, dt);
        }
        
        public System.Threading.Tasks.Task<string> AddAttendancesAsync(int[] sids, bool[] presents, int tid, System.DateTime dt) {
            return base.Channel.AddAttendancesAsync(sids, presents, tid, dt);
        }
        
        public WebClient.AttendanceService.Attendance[] GetAllAttendanceByTeacherAndDate(int tid, System.DateTime dt) {
            return base.Channel.GetAllAttendanceByTeacherAndDate(tid, dt);
        }
        
        public System.Threading.Tasks.Task<WebClient.AttendanceService.Attendance[]> GetAllAttendanceByTeacherAndDateAsync(int tid, System.DateTime dt) {
            return base.Channel.GetAllAttendanceByTeacherAndDateAsync(tid, dt);
        }
        
        public WebClient.AttendanceService.Attendance[] GetAllAttendanceByStudentAndTeacher(int sid, int tid) {
            return base.Channel.GetAllAttendanceByStudentAndTeacher(sid, tid);
        }
        
        public System.Threading.Tasks.Task<WebClient.AttendanceService.Attendance[]> GetAllAttendanceByStudentAndTeacherAsync(int sid, int tid) {
            return base.Channel.GetAllAttendanceByStudentAndTeacherAsync(sid, tid);
        }
    }
}
