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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public int ancho { get; set; }
        public int alto { get; set; }

        public Configuracion()
        {
            InitializeComponent();

            AnchoTextBox.Text = ancho.ToString();

            AltoTextBox.Text = alto.ToString();

        }


    }
}
