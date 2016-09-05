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
            string rpta = "";
            List<string> lista_errores = new List<string>();
            lista_errores = validar_cliente(cliente);
            
            if (lista_errores.Count() != 0)
            {
                rpta = data_cliente.Act_Cliente(cliente);
            }
            else
            {
                rpta = "Debe llenar Todos los Campos";
            }
            return rpta;
        }
        public DataSet Select_Cliente()
        {
            DataSet ds = new DataSet();
            if (lista_errores.Count() != 0)
            {
                ds = data_cliente.Select_Cliente();
            }

            return ds;

        }
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
    }
}
