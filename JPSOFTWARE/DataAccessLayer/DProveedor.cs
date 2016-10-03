using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class DProveedor
    {
        public string Act_Proveedor(EProveedor proveedor)
        {
            string rpta = "";
            try
            {
                DataSet ds = new DataSet();
                // agregando parametros al metodo execute query
                string query = "SP_ACTPROVEEDOR";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idproveedor", proveedor.Idproveedor);
                parameters.Add("@nombre", proveedor.Nombre);
                parameters.Add("@telefono", proveedor.Telefono);
                parameters.Add("@direccion", proveedor.Direccion);
                parameters.Add("@estatus", proveedor.Estatus);

                ds = dbconnection.execute_query(query, parameters);
                // if the query cannot be executed notify the error
                if (ds == null)
                {
                    rpta = "Error Insertando";
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

        public string Delete_Proveedor(EProveedor proveedor)
        {
            string rpta;
            try
            {
                DataSet ds = new DataSet();
                string query = "SP_DELETE_PROVEEDOR";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idproveedor", proveedor.Idproveedor);
                ds = dbconnection.execute_query(query, parameters);
                rpta = "REGISTRO ELIMINADO EXITOSAMENTE";
            }
            catch (Exception ex)
            {
                rpta = "ERROR";
            }
            return rpta;
        }

        public DataSet Select_Proveedor()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SP_SELECT_PROVEEDOR";
                ds = dbconnection.execute_query(query);
            }
            catch (Exception ex)
            {
                ds = null;
            }

            return ds;
        }

        public DataSet FilterbyID(EProveedor proveedor)
        {
            DataSet ds = new DataSet();

            try
            {
                string query = "SP_FILTERBYID_PROVEEDOR";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idproveedor", proveedor.Idproveedor);
                ds = dbconnection.execute_query(query, parameters);
            }
            catch (Exception ex)
            {
                ds = null;
            }

            return ds;
        }

        public DataSet FilterByName(EProveedor proveedor)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SP_FILTERBYNAME_PROVEEDOR";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nombre", proveedor.Nombre);
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
