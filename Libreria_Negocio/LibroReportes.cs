using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Negocio
{
    public class LibroReportes
    {
        public int ReporteLibrosDisponibles()
        {
            return Convert.ToInt32(CommonBC.ModeloLibreria.spReporteLibrosDisponibles().First().Value);
        }

        public int ReporteLibrosNoDisponibles()
        {
            return Convert.ToInt32(CommonBC.ModeloLibreria.spReporteLibrosNoDisponibles().First().Value);
        }
    }
}
