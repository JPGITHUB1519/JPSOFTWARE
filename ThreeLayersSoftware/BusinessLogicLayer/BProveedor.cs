using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using EntitiesLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BProveedor
    {
        private DProveedor data_proveedor = new DProveedor();

        public string Act_proveedor(EProveedor proveedor)
        {
            return data_proveedor.Act_Proveedor(proveedor);
        }

        public DataSet Select_proveedor()
        {
            return data_proveedor.Select_Proveedor();
        }

        public string Delete_proveedor(EProveedor proveedor)
        {
            return data_proveedor.Delete_Proveedor(proveedor);
        }

        public DataSet FilterbyID(EProveedor proveedor)
        {
            return data_proveedor.FilterbyID(proveedor);
        }

        public DataSet FilterByName(EProveedor proveedor)
        {
            return data_proveedor.FilterByName(proveedor);
        }
    }
}
