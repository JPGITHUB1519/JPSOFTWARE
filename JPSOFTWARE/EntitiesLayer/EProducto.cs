using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class EProducto
    {
        private int _idproducto;
        private int _idcategoria;
        private int _idproveedor;
        private string _nombre;
        private decimal _precio;
        private int _stock;
        private int _punto_reorden;
        private int _impuesto;

        public int Idproducto
        {
            get { return _idproducto; }
            set { _idproducto = value; }
        }

        public int Idcategoria
        {
            get { return _idcategoria; }
            set { _idcategoria = value; }
        }

        public int Idproveedor
        {
            get { return _idproveedor; }
            set { _idproveedor = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public int Punto_reorden
        {
            get { return _punto_reorden; }
            set { _punto_reorden = value; }
        }

        public int Impuesto
        {
            get { return _impuesto; }
            set { _impuesto = value; }
        }
    }
}
