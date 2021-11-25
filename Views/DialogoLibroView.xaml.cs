using Libreria.Controllers;
using Libreria.Model;
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

namespace Libreria.Views
{
    /// <summary>
    /// Lógica de interacción para DialogoLibroView.xaml
    /// </summary>
    public partial class DialogoLibroView : Window
    {
        private MainController MainController;
        public Libro Libro;
        private int pos;
        private bool mod;
        private int errores;

        public DialogoLibroView(MainController mainController)
        {
            InitializeComponent();
            MainController = mainController;
            Libro = new Libro();
            this.DataContext = Libro;
            mod = false;
        }

        public DialogoLibroView(MainController mainController, Libro modLibro, int pos)
        {
            InitializeComponent();
            MainController = mainController;
            this.Libro = modLibro;
            this.pos = pos;
            this.DataContext = Libro;
            mod = true;
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (mod)
            {
                MainController.ModificarLibro(Libro, pos);
            }
            else
            {
                MainController.AddLibro(Libro);
            }
            this.Close();
        }

        private void TextBox_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                errores++;
            }
            else
            {
                errores--;
            }
            if (errores == 0)
            {
                ButtonAceptar.IsEnabled = true;
            }
            else
            {
                ButtonAceptar.IsEnabled = false;
            }
        }
    }
}
