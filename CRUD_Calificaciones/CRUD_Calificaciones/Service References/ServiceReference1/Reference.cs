﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_Calificaciones.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService2")]
    public interface IService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/crear", ReplyAction="http://tempuri.org/IService2/crearResponse")]
        void crear(int nc, string nom, int c1, int c2, int c3, int c4, int c5);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/modificar", ReplyAction="http://tempuri.org/IService2/modificarResponse")]
        bool modificar(int nc, string nom, int c1, int c2, int c3, int c4, int c5);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/eliminar", ReplyAction="http://tempuri.org/IService2/eliminarResponse")]
        bool eliminar(int nc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/leer", ReplyAction="http://tempuri.org/IService2/leerResponse")]
        string[] leer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/buscar", ReplyAction="http://tempuri.org/IService2/buscarResponse")]
        string[] buscar(int nc);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService2Channel : CRUD_Calificaciones.ServiceReference1.IService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service2Client : System.ServiceModel.ClientBase<CRUD_Calificaciones.ServiceReference1.IService2>, CRUD_Calificaciones.ServiceReference1.IService2 {
        
        public Service2Client() {
        }
        
        public Service2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void crear(int nc, string nom, int c1, int c2, int c3, int c4, int c5) {
            base.Channel.crear(nc, nom, c1, c2, c3, c4, c5);
        }
        
        public bool modificar(int nc, string nom, int c1, int c2, int c3, int c4, int c5) {
            return base.Channel.modificar(nc, nom, c1, c2, c3, c4, c5);
        }
        
        public bool eliminar(int nc) {
            return base.Channel.eliminar(nc);
        }
        
        public string[] leer() {
            return base.Channel.leer();
        }
        
        public string[] buscar(int nc) {
            return base.Channel.buscar(nc);
        }
    }
}