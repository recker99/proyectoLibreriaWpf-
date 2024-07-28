using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Negocio
{
    public class LibroCollection
    {
        public List<Libro> ReadAll()
        {
            var libros = CommonBC.ModeloLibreria.vwLibro;
            return ObtenerLibros(libros.ToList());
        }

        private List<Libro> ObtenerLibros(List<Libreria_DALC.vwLibro> librosDALC) 
        {
            List<Libro> libroList = new List<Libro>();
            foreach (Libreria_DALC.vwLibro libro in librosDALC)
            {
                Libro l = new Libro();
                l.LibroId = libro.LibroId;
                l.Isbn = libro.Isbn;
                l.Titulo = libro.Titulo;
                l.Autor = libro.Autor;
                l.EstaDisponible = libro.Disponibilidad;

                libroList.Add(l);
            }
            return libroList;
        }

    }
}
