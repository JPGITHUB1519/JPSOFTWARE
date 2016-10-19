using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BProducto
    {
        private DProducto data_producto = new DProducto();
        private List<string> lista_errores = new List<string>();

        public string Act_Producto(EProducto producto)
        {
            return data_producto.Act_Producto(producto);
        }

        public DataSet Select_Producto()
        {
            return data_producto.Select_Producto();
        }

        public string Delete_Producto(EProducto producto)
        {
            return data_producto.Delete_Producto(producto);
        }

        public DataSet FilterbyID(EProducto producto)
        {
            return data_producto.FilterbyID(producto);
        }

        public DataSet FilterByName(EProducto producto)
        {
            return data_producto.FilterByName(producto);
        }
    }
}
