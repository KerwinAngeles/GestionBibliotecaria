using GestionBibliotecaria.Modelo;
using GestionBibliotecaria.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotecaria
{
    public class Menu
    {
        Biblioteca biblioteca = new Biblioteca();
        public void GestionarLibros()
        {
            Console.Clear();
            Console.WriteLine(
            "\n 1: Agregar Libros " +
            "\n 2: Eliminar Libros " +
            "\n 3: Modificar Libros");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                biblioteca.AgregarLibros();

            }
            else if (option == 2)
            {
                biblioteca.EliminarLibros();
            }
            else if (option == 3)
            {
                biblioteca.ModificarLibros();
            }
        }
        public void MostrarLibros()
        {
            biblioteca.MostrarLibros();
        }
        public void LibrosPrestados()
        {
            biblioteca.MostrarLibrosPrestados();
        }

        public void GestionarUsuarios()
        {
            Console.Clear();
            Console.WriteLine(
            "\n 1: Agregar Usuario " +
            "\n 2: Eliminar Usuario " +
            "\n 3: Modificar Usuario ");

            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                biblioteca.AgregarUsuarios();

            }
            else if (option == 2)
            {
                biblioteca.EliminarUsuario();
            }
            else if (option == 3)
            {
                biblioteca.ModificarUsuario();
            }
        }
        public void MostrarUsuarios()
        {
            biblioteca.MostrarUsuario();
        }

        public void Prestamos()
        {
            biblioteca.Pedirprestado();
        }

        public void Devolver()
        {
            biblioteca.DevolverLibro();
        }
    }
}
