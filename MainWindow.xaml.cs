using Libreria.Controllers;
using Libreria.Model;
using Libreria.Views;
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

namespace Libreria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainController MainController;

        public MainWindow()
        {
            InitializeComponent();
            MainController = new MainController();
            TablaLibros.DataContext = MainController;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DialogoLibroView dialogoLibroView = new DialogoLibroView(MainController);
            dialogoLibroView.Show();
        }

        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            if (TablaLibros.SelectedIndex != -1)
            {
                Libro libro = (Libro)TablaLibros.SelectedItem;
                DialogoLibroView dialogoLibroView = new DialogoLibroView(MainController, (Libro)libro.Clone(), TablaLibros.SelectedIndex);
                dialogoLibroView.Show();
            }

        }
    }
}
