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
    /// Interaction logic for ListarLibros.xaml
    /// </summary>
    public partial class ListarLibros : Window
    {

        Libreria_Negocio.LibroCollection libroCollection;

        public ListarLibros()
        {
            InitializeComponent();            
            CargarGrilla();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            var filaSeleccionada = (Libreria_Negocio.Libro)dgListadoLibros.SelectedItem;
            ActualizarLibro actualizarLibro = new ActualizarLibro(filaSeleccionada.Isbn);
            actualizarLibro.ShowDialog();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarRegistroSeleccionado();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            libroCollection = new Libreria_Negocio.LibroCollection();
            dgListadoLibros.ItemsSource = libroCollection.ReadAll();
        }

        private void EliminarRegistroSeleccionado()
        {
            var filaSeleccionada = (Libreria_Negocio.Libro)dgListadoLibros.SelectedItem;
            long isbn = filaSeleccionada.Isbn;
            string title = "Eliminar libro";
            string message = string.Format("Estás seguro de eliminar el libro {0}", isbn);

            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if(result == MessageBoxResult.Yes)
            {
                var res = filaSeleccionada.Delete(isbn) ? 
                    MessageBox.Show(string.Format("Libro {0} eliminado", isbn)) : 
                    MessageBox.Show("Libro no pudo ser eliminado");
            }
        }
    }
}
