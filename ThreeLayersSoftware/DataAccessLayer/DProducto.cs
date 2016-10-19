using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DProducto
    {
        public string Act_Producto(EProducto producto)
        {
            string rpta = "";
            DataSet ds = new DataSet();

            try
            {
                string query = "SP_ACTPRODUCTO";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idproducto", producto.Idproducto);
                parameters.Add("@idcategoria", producto.Idcategoria);
                parameters.Add("@idproveedor", producto.Idproveedor);
                parameters.Add("@nombre", producto.Nombre);
                parameters.Add("@precio", producto.Precio);
                parameters.Add("@stock", producto.Stock);
                parameters.Add("@punto_reorden", producto.Punto_reorden);
                parameters.Add("@impuesto", producto.Impuesto);

                ds = dbconnection.execute_query(query, parameters);
                if (ds == null)
                {
                    rpta = ds.ToString();
                }
                else
                {
                    rpta = "REGISTRO REGISTRADO/ACTUALIZADO EXITOSAMENTE";
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }

        public string Delete_Producto(EProducto producto)
        {
            string rpta;
            try
            {
                DataSet ds = new DataSet();
                string query = "SP_DELETE_PRODUCTO";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idproducto", producto.Idproducto);
                ds = dbconnection.execute_query(query, parameters);
                rpta = "REGISTRO ELIMINADO EXITOSAMENTE";
            }
            catch (Exception ex)
            {
                rpta = "ERROR";
            }
            return rpta;
        }

        public DataSet Select_Producto()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SP_SELECT_PRODUCTO";
                ds = dbconnection.execute_query(query);
            }
            catch (Exception ex)
            {
                ds = null;
            }

            return ds;
        }

        public DataSet FilterbyID(EProducto producto)
        {
            DataSet ds = new DataSet();

            try
            {
                string query = "SP_FILTERBYID_PRODUCTO";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idproducto", producto.Idproducto);
                ds = dbconnection.execute_query(query, parameters);
            }
            catch (Exception ex)
            {
                ds = null;
            }

            return ds;
        }

        public DataSet FilterByName(EProducto producto)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SP_FILTERBYNAME_PRODUCTO";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nombre", producto.Nombre);
                ds = dbconnection.execute_query(query, parameters);

            }
            catch (Exception ex)
            {
                ds = null;
            }

            return ds;
        }
    }
}
