using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DCategoria
    {
        public string Act_Categoria(ECategoria categoria)
        {
            string rpta = "";
            DataSet ds = new DataSet();

            try
            {
                string query = "SP_ACTCATEGORIA";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idcategoria", categoria.Idcategoria);
                parameters.Add("@categoria", categoria.Categoria);
                parameters.Add("@descripcion", categoria.Descripcion);
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
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }

        public string Delete_Categoria(ECategoria categoria)
        {
            string rpta;
            try
            {
                DataSet ds = new DataSet();
                string query = "SP_DELETE_CATEGORIA";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idcategoria", categoria.Idcategoria);
                ds = dbconnection.execute_query(query, parameters);
                rpta = "REGISTRO ELIMINADO EXITOSAMENTE";
            }
            catch (Exception ex)
            {
                rpta = "ERROR";
            }
            return rpta;
        }

        public DataSet Select_Categoria()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SP_SELECT_CATEGORIA";
                ds = dbconnection.execute_query(query);
            }
            catch (Exception ex)
            {
                ds = null;
            }

            return ds;
        }

        public DataSet FilterbyID(ECategoria categoria)
        {
            DataSet ds = new DataSet();

            try
            {
                string query = "SP_FILTERBYID_CATEGORIA";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idcategoria", categoria.Idcategoria);
                ds = dbconnection.execute_query(query, parameters);
            }
            catch (Exception ex)
            {
                ds = null;
            }

            return ds;
        }

        public DataSet FilterByName(ECategoria categoria)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SP_FILTERBYNAME_CATEGORIA";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@categoria", categoria.Categoria);
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
