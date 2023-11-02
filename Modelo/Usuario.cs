using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBibliotecaria.Repositorios;

namespace GestionBibliotecaria.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }

        public Usuario() 
        { 

        }
        public Usuario(int identificacion, string nombre, string apellido, string correo)
        {
            Id = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
        }

        public void PedirLibroPrestado(RepositorioLibros repositorioLibros, int idLibro)
        {
            if (repositorioLibros.LibrosPrestados.Any(l => l.IdLibro == idLibro))
            {
                Console.WriteLine("Lo sentimos, ya usted tiene un libro prestado");
                return;
            }

            Libro librosPrestado = repositorioLibros.Libros.FirstOrDefault(l => l.IdLibro == idLibro);

            if (librosPrestado != null)
            {
                repositorioLibros.LibrosPrestados.Add(librosPrestado);
                repositorioLibros.EliminarLibros(idLibro);
                Console.WriteLine($"El libro con el titulo: {librosPrestado.Titulo} y ID: {librosPrestado.IdLibro} ha sido prestado al usuario: {Nombre} {Apellido}");    
            }
            else
            {
                Console.WriteLine($"El libro {idLibro} no esta disponible");
            }
        }

        public void DevolverLibroPrestado(RepositorioLibros repositorioLibros, int idLibro)
        {
            Libro librosDevueltos = repositorioLibros.LibrosPrestados.FirstOrDefault(l => l.IdLibro == idLibro);

            if (librosDevueltos != null)
            {
                repositorioLibros.LibrosPrestados.Remove(librosDevueltos);
                repositorioLibros.AgregarLibros(librosDevueltos);
                Console.WriteLine($"El libro con el titulo: {librosDevueltos.Titulo} y ID: {librosDevueltos.IdLibro} ha sido devuelto por el usuario: {Nombre} {Apellido}");
            }
            else
            {
                Console.WriteLine($"El libro con el {idLibro} se encuentra disponible");
            }
        }
        public void InformacionUsuario()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellidos: {Apellido}");
            Console.WriteLine($"Correo: {Correo}");
        }
    }
}
