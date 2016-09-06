using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntitiesLayer;

namespace DataAccessLayer
{
    public class DCliente
    {
        public string Act_Cliente(ECliente cliente)
        {
            string rpta = "";
            try
            {
                DataSet ds = new DataSet();
                // agregando parametros al metodo execute query
                string query = "SP_ACTCLIENTE";
                Dictionary<string, object> parameters = new Dictionary<string,object>();
                parameters.Add("@idcliente", cliente.Idcliente);
                parameters.Add("@nombre", cliente.Nombre);
                parameters.Add("@apellido", cliente.Apellido);
                parameters.Add("@direccion", cliente.Direccion);
                parameters.Add("@telefono", cliente.Telefono);
                parameters.Add("@email", cliente.Email);
                parameters.Add("@estatus", cliente.Status);
                ds = dbconnection.execute_query(query, parameters);
                if (ds == null)
                {
                    rpta = "Error Insertando";
                }
                else
                {
                    rpta = "REGISTRO REGISTRADO/ACTUALIZADO EXITOSAMENTE";
                }
    
            }
            catch(Exception ex)
            {
 
                rpta = ex.Message;
            }

            return rpta;  
        }

        public string Delete_Cliente(ECliente cliente)
        {
            string rpta;
            try
            {
                DataSet ds = new DataSet();
                string query = "SP_DELETE_CLIENTE";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idcliente", cliente.Idcliente);
                ds = dbconnection.execute_query(query, parameters);
                rpta = "REGISTRO ELIMINADO EXITOSAMENTE";
            }
            catch(Exception ex)
            {
                rpta = "ERROR";
            }
            return rpta;  
        }

        public DataSet Select_Cliente()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SP_SELECT_CLIENTE";
                ds = dbconnection.execute_query(query);
            }
            catch(Exception ex)
            {
                ds = null;
            }

            return ds;
        }

        public DataSet FilterbyID(ECliente cliente)
        {
            DataSet ds = new DataSet();

            try
            {
                string query = "SP_FILTERID_CLIENTE";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idcliente", cliente.Idcliente);
                ds = dbconnection.execute_query(query, parameters);
            }
            catch (Exception ex)
            {
                ds = null;
            }

            return ds;
        }

        public DataSet FilterByName(ECliente cliente)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SP_FILTERBYNAME_CLIENTE";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nombre", cliente.Nombre);
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
