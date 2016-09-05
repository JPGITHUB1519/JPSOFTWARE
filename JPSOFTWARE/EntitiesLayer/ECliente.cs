using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class ECliente
    {
        private int _idcliente;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _telefono;
        private string _email;

        public int Idcliente
        {
            get { return _idcliente; }
            set { _idcliente = value; }
        }
        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
       
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
       
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private bool _status;

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
