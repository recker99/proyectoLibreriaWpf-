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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Libreria_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Libreria_Negocio.LibroCollection libroCollection;
        Libreria_Negocio.LibroReportes libroReportes;
        public MainWindow()
        {
            InitializeComponent();
            libroCollection = new Libreria_Negocio.LibroCollection();
            CargarGrilla();
        }

        private void optAgregarLibro_Click(object sender, RoutedEventArgs e)
        {
            Vistas.AgregarLibro agregarLibro = new Vistas.AgregarLibro();
            agregarLibro.ShowDialog();
        }

        private void optListarLibros_Click(object sender, RoutedEventArgs e)
        {
            Vistas.ListarLibros listarLibros = new Vistas.ListarLibros();
            listarLibros.ShowDialog();
        }

        private void optReportes_Click(object sender, RoutedEventArgs e)
        {
            libroReportes = new Libreria_Negocio.LibroReportes();
            int librosDisponibles = libroReportes.ReporteLibrosDisponibles();
            int librosNoDisponibles = libroReportes.ReporteLibrosNoDisponibles();
            string message = string.Format(
                "Libros disponibles: {0} \n " +
                "Libros no disponibles: {1}", 
                librosDisponibles, 
                librosNoDisponibles
            );
            MessageBox.Show(message);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgListadoLibros.ItemsSource = libroCollection.ReadAll();
        }

        private void dgListadoLibros_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if(e.Column.Header.ToString() == "Error" || e.Column.Header.ToString() == "ErrorCollection")
            {
                e.Column.Visibility = Visibility.Collapsed;
            }
        }
    }
}
