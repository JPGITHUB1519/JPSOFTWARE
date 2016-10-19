using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;
using EntitiesLayer;

namespace BusinessLogicLayer
{
    public class BCategoria
    {
        private DCategoria data_categoria = new DCategoria();
        private List<string> lista_errores = new List<string>();

        public string Act_categoria(ECategoria categoria)
        {
            return data_categoria.Act_Categoria(categoria);
        }

        public DataSet Select_categoria()
        {
            return data_categoria.Select_Categoria();
        }

        public string Delete_categoria(ECategoria categoria)
        {
            return data_categoria.Delete_Categoria(categoria);
        }

        public DataSet FilterbyID(ECategoria categoria)
        {
            return data_categoria.FilterbyID(categoria);
        }

        public DataSet FilterByName(ECategoria categoria)
        {
            return data_categoria.FilterByName(categoria);
        }
    }
}
