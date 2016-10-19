using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class EProveedor
    {
        private int idproveedor;
        private string nombre;
        private string telefono;
        private string direccion;
        private bool estatus;
       
        public int Idproveedor
        {
            get { return idproveedor; }
            set { idproveedor = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public bool Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }
    }
}
