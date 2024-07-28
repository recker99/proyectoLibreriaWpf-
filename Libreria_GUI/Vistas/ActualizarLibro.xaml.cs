using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Libreria_GUI.Vistas
{
    /// <summary>
    /// Interaction logic for ActualizarLibro.xaml
    /// </summary>
    public partial class ActualizarLibro : Window
    {
        Libreria_Negocio.Libro libro;

        public ActualizarLibro(long isbn)
        {
            InitializeComponent();
            this.Title = string.Format("Actualizar libro {0}", isbn);
            
            libro = new Libreria_Negocio.Libro();

            CargarFormulario(isbn);

        }

        private void btnActualizarLibro_Click(object sender, RoutedEventArgs e)
        {
            libro.Titulo = txtTituloLibro.Text;
            libro.Autor = txtAutorLibro.Text;
            libro.EstaDisponible = (chkDisponible.IsChecked.Value) ? true : false;

            bool response = libro.Update();

            if (response)
            {
                MessageBox.Show(string.Format("Libro {0} ha sido actualizado exitósamente!", libro.Isbn));
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("No fue posible actualizar el libro {0}", libro.Isbn));
                this.Close();
            }
        }

        private void CargarFormulario(long isbn)
        {
            bool response = libro.Read(isbn);
            if (response)
            {
                txtIsbn.Text = libro.Isbn.ToString();
                txtTituloLibro.Text = libro.Titulo;
                txtAutorLibro.Text = libro.Autor;
                chkDisponible.IsChecked = (libro.EstaDisponible) ? true : false;
            }
            else
            {
                MessageBox.Show(string.Format("El libro {0} no fue encontrado.", isbn));
            }
        }
    }
}
