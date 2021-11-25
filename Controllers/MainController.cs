using Libreria.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Controllers
{
    public class MainController
    {
        public ObservableCollection<Libro> ListaLibros { get; set; }

        public MainController()
        {
            ListaLibros = new ObservableCollection<Libro>();
            ListaLibros.Add(new Libro("Titulo", "Autor", DateTime.Now));
        }

        public void AddLibro(Libro libro)
        {
            ListaLibros.Add(libro);
        }

        public void ModificarLibro(Libro libro, int pos)
        {
            ListaLibros[pos] = libro;
        }

    }
}
