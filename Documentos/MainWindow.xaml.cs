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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ancho;
        int alto;

        public MainWindow()
        {
            InitializeComponent();
            ancho = 500;
            alto = 500;
        }

        private void Button_Click_Documento(object sender, RoutedEventArgs e)
        {
            AgregarDocumento agregarDocumentoVentana = new AgregarDocumento();

            agregarDocumentoVentana.Owner = this;

            agregarDocumentoVentana.Title = "Documento " + this.OwnedWindows.Count;
            agregarDocumentoVentana.Width = ancho;
            agregarDocumentoVentana.Height = alto;

            agregarDocumentoVentana.Show();
        }

        private void Button_Click_Configuracion(object sender, RoutedEventArgs e)
        {
            Configuracion ventanaConfiguracion = new Configuracion();

            ventanaConfiguracion.Owner = this;

            ventanaConfiguracion.Title = "Configuracion";
            
            ventanaConfiguracion.ancho = this.ancho;
            ventanaConfiguracion.alto = this.alto;

            ventanaConfiguracion.ShowDialog();
        }
    }
}
