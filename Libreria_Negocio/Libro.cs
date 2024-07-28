using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_DALC;

namespace Libreria_Negocio
{
    public class Libro : ObservableObject, IPersistente, IDataErrorInfo
    {
        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();
        public int LibroId { get; set; }

        private long _isbn;
        private string _titulo;
        private string _autor;
        private bool _estaDisponible;

        public long Isbn
        {
            get { return _isbn; }
            set
            {
                OnPropertyChanged(ref _isbn, value);
            }
        }
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                OnPropertyChanged(ref _titulo, value);
            }
        }
        public string Autor
        {
            get { return _autor; }
            set
            {
                OnPropertyChanged(ref _autor, value);
            }
        }
        public bool EstaDisponible
        {
            get { return _estaDisponible; }
            set
            {
                OnPropertyChanged(ref _estaDisponible, value);
            }
        }

        public string Error { get { return null; } }

        public string this[string name]
        {
            get
            {
                string res = null;

                switch (name)
                {
                    case "Isbn":
                        int len = Isbn.ToString().Length;
                        if (string.IsNullOrEmpty(Isbn.ToString()))
                            res = "ISBN es obligatorio";

                        if (len < 10 || len > 13)
                            res = "ISBN solo puede tener 10 o 13 dígitos";

                        if (len == 11 || len == 12)
                            res = "ISBN no es válido";
                        break;

                    case "Titulo":
                        if (string.IsNullOrEmpty(Titulo))
                            res = "Titulo es obligatorio";
                        break;

                    case "Autor":
                        if (string.IsNullOrEmpty(Autor))
                            res = "Autor es obligatorio";
                        break;
                }

                if (res == null)
                {
                    // Si no hay error, eliminamos cualquier entrada previa
                    ErrorCollection.Remove(name);
                }
                else
                {
                    // Si hay error, actualizamos o añadimos la entrada
                    if (ErrorCollection.ContainsKey(name))
                        ErrorCollection[name] = res;
                    else
                        ErrorCollection.Add(name, res);
                }

                OnPropertyChanged("ErrorCollection");

                return res;
            }
        }

        public bool Create()
        {
            try
            {
                CommonBC.ModeloLibreria.spLibroSave(
                    this.Isbn,
                    this.Titulo,
                    this.Autor,
                    this.EstaDisponible
                );

                CommonBC.ModeloLibreria.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Read(long isbn)
        {
            try
            {
                Libreria_DALC.vwLibro libro = CommonBC.ModeloLibreria.vwLibro.First(l => l.Isbn == isbn);

                this.LibroId = libro.LibroId;
                this.Isbn = libro.Isbn;
                this.Titulo = libro.Titulo;
                this.Autor = libro.Autor;
                this.EstaDisponible = libro.Disponibilidad;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                CommonBC.ModeloLibreria.spLibroUpdateByIsbn(
                    this.Isbn,
                    this.Titulo,
                    this.Autor,
                    this.EstaDisponible
                );

                CommonBC.ModeloLibreria.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(long isbn)
        {
            try
            {
                CommonBC.ModeloLibreria.spLibroDeleteByIsbn(isbn);
                CommonBC.ModeloLibreria.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

