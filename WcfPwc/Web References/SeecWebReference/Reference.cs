﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.296
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.296.
// 
#pragma warning disable 1591

namespace WcfPwc.SeecWebReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsReplySoap", Namespace="http://tempuri.org/")]
    public partial class wsReply : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback dataFromWebOperationCompleted;
        
        private System.Threading.SendOrPostCallback insertToWebOperationCompleted;
        
        private System.Threading.SendOrPostCallback openExecuteFromLocalOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkDBConnectionOperationCompleted;
        
        private System.Threading.SendOrPostCallback phaseFromWebOperationCompleted;
        
        private System.Threading.SendOrPostCallback distFromWebOperationCompleted;
        
        private System.Threading.SendOrPostCallback dataIndFromWebOperationCompleted;
        
        private System.Threading.SendOrPostCallback insertIndToWebOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsReply() {
            this.Url = global::WcfPwc.Properties.Settings.Default.WcfPwc_SeecWebReference_wsRequest;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event dataFromWebCompletedEventHandler dataFromWebCompleted;
        
        /// <remarks/>
        public event insertToWebCompletedEventHandler insertToWebCompleted;
        
        /// <remarks/>
        public event openExecuteFromLocalCompletedEventHandler openExecuteFromLocalCompleted;
        
        /// <remarks/>
        public event checkDBConnectionCompletedEventHandler checkDBConnectionCompleted;
        
        /// <remarks/>
        public event phaseFromWebCompletedEventHandler phaseFromWebCompleted;
        
        /// <remarks/>
        public event distFromWebCompletedEventHandler distFromWebCompleted;
        
        /// <remarks/>
        public event dataIndFromWebCompletedEventHandler dataIndFromWebCompleted;
        
        /// <remarks/>
        public event insertIndToWebCompletedEventHandler insertIndToWebCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/dataFromWeb", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet dataFromWeb(int branch, int phase) {
            object[] results = this.Invoke("dataFromWeb", new object[] {
                        branch,
                        phase});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void dataFromWebAsync(int branch, int phase) {
            this.dataFromWebAsync(branch, phase, null);
        }
        
        /// <remarks/>
        public void dataFromWebAsync(int branch, int phase, object userState) {
            if ((this.dataFromWebOperationCompleted == null)) {
                this.dataFromWebOperationCompleted = new System.Threading.SendOrPostCallback(this.OndataFromWebOperationCompleted);
            }
            this.InvokeAsync("dataFromWeb", new object[] {
                        branch,
                        phase}, this.dataFromWebOperationCompleted, userState);
        }
        
        private void OndataFromWebOperationCompleted(object arg) {
            if ((this.dataFromWebCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dataFromWebCompleted(this, new dataFromWebCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/insertToWeb", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string insertToWeb(
                    int user, 
                    int manual, 
                    int standard, 
                    int activity, 
                    int branch, 
                    int department, 
                    int owner, 
                    int phase, 
                    int reached, 
                    int notReached, 
                    int notApplicable, 
                    string certificationLevel, 
                    string commentTitle, 
                    string comment, 
                    string recommend, 
                    System.DateTime createdDate, 
                    int stdType) {
            object[] results = this.Invoke("insertToWeb", new object[] {
                        user,
                        manual,
                        standard,
                        activity,
                        branch,
                        department,
                        owner,
                        phase,
                        reached,
                        notReached,
                        notApplicable,
                        certificationLevel,
                        commentTitle,
                        comment,
                        recommend,
                        createdDate,
                        stdType});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void insertToWebAsync(
                    int user, 
                    int manual, 
                    int standard, 
                    int activity, 
                    int branch, 
                    int department, 
                    int owner, 
                    int phase, 
                    int reached, 
                    int notReached, 
                    int notApplicable, 
                    string certificationLevel, 
                    string commentTitle, 
                    string comment, 
                    string recommend, 
                    System.DateTime createdDate, 
                    int stdType) {
            this.insertToWebAsync(user, manual, standard, activity, branch, department, owner, phase, reached, notReached, notApplicable, certificationLevel, commentTitle, comment, recommend, createdDate, stdType, null);
        }
        
        /// <remarks/>
        public void insertToWebAsync(
                    int user, 
                    int manual, 
                    int standard, 
                    int activity, 
                    int branch, 
                    int department, 
                    int owner, 
                    int phase, 
                    int reached, 
                    int notReached, 
                    int notApplicable, 
                    string certificationLevel, 
                    string commentTitle, 
                    string comment, 
                    string recommend, 
                    System.DateTime createdDate, 
                    int stdType, 
                    object userState) {
            if ((this.insertToWebOperationCompleted == null)) {
                this.insertToWebOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertToWebOperationCompleted);
            }
            this.InvokeAsync("insertToWeb", new object[] {
                        user,
                        manual,
                        standard,
                        activity,
                        branch,
                        department,
                        owner,
                        phase,
                        reached,
                        notReached,
                        notApplicable,
                        certificationLevel,
                        commentTitle,
                        comment,
                        recommend,
                        createdDate,
                        stdType}, this.insertToWebOperationCompleted, userState);
        }
        
        private void OninsertToWebOperationCompleted(object arg) {
            if ((this.insertToWebCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertToWebCompleted(this, new insertToWebCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/openExecuteFromLocal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string openExecuteFromLocal(string insertStr) {
            object[] results = this.Invoke("openExecuteFromLocal", new object[] {
                        insertStr});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void openExecuteFromLocalAsync(string insertStr) {
            this.openExecuteFromLocalAsync(insertStr, null);
        }
        
        /// <remarks/>
        public void openExecuteFromLocalAsync(string insertStr, object userState) {
            if ((this.openExecuteFromLocalOperationCompleted == null)) {
                this.openExecuteFromLocalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnopenExecuteFromLocalOperationCompleted);
            }
            this.InvokeAsync("openExecuteFromLocal", new object[] {
                        insertStr}, this.openExecuteFromLocalOperationCompleted, userState);
        }
        
        private void OnopenExecuteFromLocalOperationCompleted(object arg) {
            if ((this.openExecuteFromLocalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.openExecuteFromLocalCompleted(this, new openExecuteFromLocalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkDBConnection", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet checkDBConnection() {
            object[] results = this.Invoke("checkDBConnection", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void checkDBConnectionAsync() {
            this.checkDBConnectionAsync(null);
        }
        
        /// <remarks/>
        public void checkDBConnectionAsync(object userState) {
            if ((this.checkDBConnectionOperationCompleted == null)) {
                this.checkDBConnectionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckDBConnectionOperationCompleted);
            }
            this.InvokeAsync("checkDBConnection", new object[0], this.checkDBConnectionOperationCompleted, userState);
        }
        
        private void OncheckDBConnectionOperationCompleted(object arg) {
            if ((this.checkDBConnectionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkDBConnectionCompleted(this, new checkDBConnectionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/phaseFromWeb", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet phaseFromWeb() {
            object[] results = this.Invoke("phaseFromWeb", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void phaseFromWebAsync() {
            this.phaseFromWebAsync(null);
        }
        
        /// <remarks/>
        public void phaseFromWebAsync(object userState) {
            if ((this.phaseFromWebOperationCompleted == null)) {
                this.phaseFromWebOperationCompleted = new System.Threading.SendOrPostCallback(this.OnphaseFromWebOperationCompleted);
            }
            this.InvokeAsync("phaseFromWeb", new object[0], this.phaseFromWebOperationCompleted, userState);
        }
        
        private void OnphaseFromWebOperationCompleted(object arg) {
            if ((this.phaseFromWebCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.phaseFromWebCompleted(this, new phaseFromWebCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/distFromWeb", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet distFromWeb(int ronda) {
            object[] results = this.Invoke("distFromWeb", new object[] {
                        ronda});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void distFromWebAsync(int ronda) {
            this.distFromWebAsync(ronda, null);
        }
        
        /// <remarks/>
        public void distFromWebAsync(int ronda, object userState) {
            if ((this.distFromWebOperationCompleted == null)) {
                this.distFromWebOperationCompleted = new System.Threading.SendOrPostCallback(this.OndistFromWebOperationCompleted);
            }
            this.InvokeAsync("distFromWeb", new object[] {
                        ronda}, this.distFromWebOperationCompleted, userState);
        }
        
        private void OndistFromWebOperationCompleted(object arg) {
            if ((this.distFromWebCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.distFromWebCompleted(this, new distFromWebCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/dataIndFromWeb", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet dataIndFromWeb(int branch, int phase) {
            object[] results = this.Invoke("dataIndFromWeb", new object[] {
                        branch,
                        phase});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void dataIndFromWebAsync(int branch, int phase) {
            this.dataIndFromWebAsync(branch, phase, null);
        }
        
        /// <remarks/>
        public void dataIndFromWebAsync(int branch, int phase, object userState) {
            if ((this.dataIndFromWebOperationCompleted == null)) {
                this.dataIndFromWebOperationCompleted = new System.Threading.SendOrPostCallback(this.OndataIndFromWebOperationCompleted);
            }
            this.InvokeAsync("dataIndFromWeb", new object[] {
                        branch,
                        phase}, this.dataIndFromWebOperationCompleted, userState);
        }
        
        private void OndataIndFromWebOperationCompleted(object arg) {
            if ((this.dataIndFromWebCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dataIndFromWebCompleted(this, new dataIndFromWebCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/insertIndToWeb", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string insertIndToWeb(int branch, int phase, string fMonth, string sMonth, string tMonth, decimal isvr1, decimal iscr1, decimal isvr2, decimal iscr2, decimal isvr3, decimal iscr3) {
            object[] results = this.Invoke("insertIndToWeb", new object[] {
                        branch,
                        phase,
                        fMonth,
                        sMonth,
                        tMonth,
                        isvr1,
                        iscr1,
                        isvr2,
                        iscr2,
                        isvr3,
                        iscr3});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void insertIndToWebAsync(int branch, int phase, string fMonth, string sMonth, string tMonth, decimal isvr1, decimal iscr1, decimal isvr2, decimal iscr2, decimal isvr3, decimal iscr3) {
            this.insertIndToWebAsync(branch, phase, fMonth, sMonth, tMonth, isvr1, iscr1, isvr2, iscr2, isvr3, iscr3, null);
        }
        
        /// <remarks/>
        public void insertIndToWebAsync(int branch, int phase, string fMonth, string sMonth, string tMonth, decimal isvr1, decimal iscr1, decimal isvr2, decimal iscr2, decimal isvr3, decimal iscr3, object userState) {
            if ((this.insertIndToWebOperationCompleted == null)) {
                this.insertIndToWebOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertIndToWebOperationCompleted);
            }
            this.InvokeAsync("insertIndToWeb", new object[] {
                        branch,
                        phase,
                        fMonth,
                        sMonth,
                        tMonth,
                        isvr1,
                        iscr1,
                        isvr2,
                        iscr2,
                        isvr3,
                        iscr3}, this.insertIndToWebOperationCompleted, userState);
        }
        
        private void OninsertIndToWebOperationCompleted(object arg) {
            if ((this.insertIndToWebCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.insertIndToWebCompleted(this, new insertIndToWebCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void dataFromWebCompletedEventHandler(object sender, dataFromWebCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dataFromWebCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dataFromWebCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void insertToWebCompletedEventHandler(object sender, insertToWebCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertToWebCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertToWebCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void openExecuteFromLocalCompletedEventHandler(object sender, openExecuteFromLocalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class openExecuteFromLocalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal openExecuteFromLocalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void checkDBConnectionCompletedEventHandler(object sender, checkDBConnectionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkDBConnectionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkDBConnectionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void phaseFromWebCompletedEventHandler(object sender, phaseFromWebCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class phaseFromWebCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal phaseFromWebCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void distFromWebCompletedEventHandler(object sender, distFromWebCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class distFromWebCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal distFromWebCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void dataIndFromWebCompletedEventHandler(object sender, dataIndFromWebCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dataIndFromWebCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dataIndFromWebCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void insertIndToWebCompletedEventHandler(object sender, insertIndToWebCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class insertIndToWebCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal insertIndToWebCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591