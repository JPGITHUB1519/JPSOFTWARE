using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class ECategoria
    {
        private int _idcategoria;
        private string categoria;  
        private string descripcion;

        public int Idcategoria
        {
            get { return _idcategoria; }
            set { _idcategoria = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
