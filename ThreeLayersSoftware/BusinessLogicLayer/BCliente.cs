using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BCliente
    {
        private DCliente data_cliente = new DCliente();
        private List<string> lista_errores = new List<string>();

        public string Act_Cliente(ECliente cliente)
        {
            return data_cliente.Act_Cliente(cliente);
        }

        public DataSet Select_Cliente()
        {
            return data_cliente.Select_Cliente();
        }

        public string Delete_Cliente(ECliente cliente)
        {
            return data_cliente.Delete_Cliente(cliente);
        }

        public DataSet FilterbyID(ECliente cliente)
        {
            return data_cliente.FilterbyID(cliente);
        }

        public DataSet FilterByName(ECliente cliente)
        {
            return data_cliente.FilterByName(cliente);
        }

        /*
        public string Delete_Cliente(ECliente cliente)
        {
            string rpta = "";
            List<string> Lista_Errores = new 
        }
        */

        /* validacion 
        public List<string> validar_cliente(ECliente cliente)
        {
            // FORCE PARA VALIDAR INT -> CONVERTIRLO A STRING Y LUEGO PREGUNTAR
            if(string.IsNullOrEmpty(Convert.ToString(cliente.Idcliente)))
            {
                lista_errores.Add("DEBE LLENAR EL ID");
            }
            if(string.IsNullOrEmpty(cliente.Nombre))
            {
                lista_errores.Add("DEBE LLENAR EL NOMBRE DEL CLIENTE");
            }
            if(string.IsNullOrEmpty(cliente.Apellido))
            {
                lista_errores.Add("DEBE LLENAR EL APELLIDO DEL CLIENTE");
            }
            if(string.IsNullOrEmpty(cliente.Direccion))
            {
                lista_errores.Add("DEBE LLENAR LA DIRECCION DEL CLIENTE");
            }
            if(string.IsNullOrEmpty(cliente.Telefono))
            {
                lista_errores.Add("DEBE LLENAR EL TELEFONO DEL CLIENTE");
            }
            if (string.IsNullOrEmpty(cliente.Email))
            {
                lista_errores.Add("DEBE LLENAR EL EMAIL");
            }

            return lista_errores;
        }
         * */
    }
}
