using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Negocio
{
    public class CommonBC
    {
        private static Libreria_DALC.LibreriaDBEntities8 _modeloLibreria;

        public static Libreria_DALC.LibreriaDBEntities8 ModeloLibreria
        {
            get
            {
                if(_modeloLibreria == null)
                {
                    _modeloLibreria = new Libreria_DALC.LibreriaDBEntities8();
                }
                return _modeloLibreria;
            }           
        }

        public CommonBC() { }
    }
}
