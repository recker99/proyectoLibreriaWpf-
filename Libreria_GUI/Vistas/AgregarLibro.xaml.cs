using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AgregarLibro.xaml
    /// </summary>
    public partial class AgregarLibro : Window
    {
        private static Regex s_regex = new Regex("[^0-9]+");

        Libreria_Negocio.Libro libro;

        public AgregarLibro()
        {
            InitializeComponent();
            libro = new Libreria_Negocio.Libro();
            this.DataContext = libro;
        }

        private void btnAgregarLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {              
                bool response = libro.Create();

                if (response)
                {
                    MessageBox.Show("Libro fue agregado correctamente");
                    AgregarOtroLibro();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intentelo más tarde");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }

        private void AgregarOtroLibro()
        {
            string title = "Agregar nuevo Libro";
            string message = "¿Desea agregar nuevo libro?";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if(result == MessageBoxResult.No)
            {
                this.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtIsbn.Text = string.Empty;
            txtTituloLibro.Text = string.Empty;
            txtAutorLibro.Text = string.Empty;
            chkDisponible.IsChecked = false;
        }
    }
}
