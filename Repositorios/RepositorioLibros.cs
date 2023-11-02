using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBibliotecaria.Modelo;

namespace GestionBibliotecaria.Repositorios
{
    public class RepositorioLibros
    {
        public List<Libro> Libros { get; set; }
        public List<Libro> LibrosPrestados { get; set; }

        public RepositorioLibros()
        {
            Libros = new List<Libro>();
            LibrosPrestados = new List<Libro>();
        }

        public void AgregarLibros(Libro libro)
        {
            bool existe = Libros.Any(l => l.IdLibro == libro.IdLibro);
            if (!existe)
            {
                Libros.Add(libro);
                Console.WriteLine("Se agrego un libro exitosamente.");
            }
            else
            {
                Console.WriteLine("Ya existe un libro con ese id");
            }    
        }

        public bool EliminarLibros(int idLibro)
        {
            Libro eliminarLibro = Libros.FirstOrDefault(libro => libro.IdLibro == idLibro);
            if (eliminarLibro != null)
            {
                Libros.Remove(eliminarLibro);
               // Console.WriteLine($"El libro con el ID {idLibro} fue eliminado");
                return true;
            }
            else
            {
                Console.WriteLine($"No se encontro ningun libro con el numero de ID {idLibro}");
                return false;
            }
        }

        public bool ModificarLibro(int idLibro, string titulo, string genero, string author, DateTime anoPublicacion)
        {
            Libro modificarLibro = Libros.FirstOrDefault(libro => libro.IdLibro == idLibro);
            if (modificarLibro != null)
            {
                modificarLibro.Titulo = titulo;
                modificarLibro.Genero = genero;
                modificarLibro.Author = author;
                modificarLibro.AnoPublicacion = anoPublicacion;
                Console.WriteLine("El libro fue modificado exitosamente");
                return true;
            }
            else
            {
                Console.WriteLine($"No se encontro ningun libro con el numero de ID {idLibro}");
                return false;
            }
        }
        public void MostrarLibros()
        {
            Console.WriteLine("LIBROS DISPONIBLES");
            foreach (var libros in Libros)
            {
                libros.MostrarInfo();
                Console.WriteLine();
            }
        }
        public void MostrarLibrosPrestados()
        {
            
            Console.WriteLine("LIBROS PRESTADOS");
            foreach (var librosPrestados in LibrosPrestados)
            {
                librosPrestados.MostrarInfo();
                Console.WriteLine();
            }
        }

    }
}
