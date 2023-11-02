using GestionBibliotecaria.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotecaria.Modelo
{
    public class Biblioteca
    {

        RepositorioLibros rLibros = new RepositorioLibros();
        RepositorioUsuarios rUsuarios = new RepositorioUsuarios();
        Usuario Usuario = new Usuario();
        public void AgregarLibros()
        {
            Console.WriteLine("Ingrese el id del libro");
            int idLibro = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el titulo del libro");
            string titulo = Console.ReadLine();

            Console.WriteLine($"Ingrese el genero del libro {titulo}");
            string genero = Console.ReadLine();

            Console.WriteLine($"Ingrese el autor del libro {titulo}");
            string author = Console.ReadLine();

            Console.WriteLine($"Ingrese el año de publicacion del libro {titulo}");
            DateTime anoPublicacion = DateTime.Parse(Console.ReadLine());

            Libro libro = new Libro(idLibro, titulo, genero, author, anoPublicacion);
            rLibros.AgregarLibros(libro);
        }

        public void EliminarLibros()
        {
            Console.WriteLine("Ingrese el id del libro que desea eliminar");
            int idLibro = int.Parse(Console.ReadLine());
            rLibros.EliminarLibros(idLibro);
        }

        public void ModificarLibros()
        {
            Console.WriteLine("Ingrese el id del libro");
            int idLibro = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el titulo del libro");
            string titulo = Console.ReadLine();

            Console.WriteLine($"Ingrese el genero del libro {titulo}");
            string genero = Console.ReadLine();

            Console.WriteLine($"Ingrese el autor del libro {titulo}");
            string author = Console.ReadLine();

            Console.WriteLine($"Ingrese el año de publicacion del libro {titulo}");
            DateTime anoPublicacion = DateTime.Parse(Console.ReadLine());
            rLibros.ModificarLibro(idLibro, titulo, genero, author, anoPublicacion);
        }

        public void MostrarLibros()
        {
           rLibros.MostrarLibros();
        }

        public void AgregarUsuarios()
        {
            Console.WriteLine("Ingrese el id del usuario");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del usuario");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Ingrese los apellidos para el usuario {nombre}");
            string apellidos = Console.ReadLine();

            Console.WriteLine($"Ingrese el correo del usuario {nombre} {apellidos}");
            string correo = Console.ReadLine();

            Usuario usuario = new Usuario(id, nombre, apellidos, correo);
            rUsuarios.AgregarUsuario(usuario);
        }

        public void EliminarUsuario()
        {
            Console.WriteLine("Ingrese el id del usuario que desea eliminar");
            int idUsuario = int.Parse(Console.ReadLine());
            rUsuarios.EliminarUsuario(idUsuario);
        }

        public void ModificarUsuario()
        {
            Console.WriteLine("Ingrese el id del usuario");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del usuario a modificar");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Ingrese los apellidos del usuario {nombre}");
            string apellidos = Console.ReadLine();

            Console.WriteLine($"Ingrese el correo del usuario {nombre}");
            string correo = Console.ReadLine();

            rUsuarios.ModificarUsuario(id, nombre, apellidos, correo);
        }

        public void MostrarUsuario()
        {
            Console.WriteLine("Lista de usuarios");
            foreach (var usuario in rUsuarios.Usuarios)
            {
                usuario.InformacionUsuario();
                Console.WriteLine();
            }
        }

        public void Pedirprestado()
        {
            Console.WriteLine("Ingrese el id del usuario que pedira un libro prestado");
            int idUsuario = int.Parse(Console.ReadLine());

            Usuario = rUsuarios.Usuarios.Find(I => I.Id == idUsuario);
            if (Usuario != null)
            {
                Console.WriteLine("Ingrese el id del libro que desea tomar");
                int idLibro = int.Parse(Console.ReadLine());

                Usuario.PedirLibroPrestado(rLibros, idLibro);
            }
            else
            {
                Console.WriteLine("Usuario no existente");
            }
        }

        public void DevolverLibro()
        {
            Console.WriteLine("Ingrese el id del usuario que devolvera el libro");
            int idUsuario = int.Parse(Console.ReadLine());

            Usuario = rUsuarios.Usuarios.Find(I => I.Id == idUsuario);
            if (Usuario != null)
            {
                Console.WriteLine("Ingrese el id del libro que desea devolver");
                int idLibro = int.Parse(Console.ReadLine());

                Usuario.DevolverLibroPrestado(rLibros, idLibro);
            }
            else
            {
                Console.WriteLine("Usuario no existente");
            }
        }

        public void MostrarLibrosPrestados()
        {
            rLibros.MostrarLibrosPrestados();
        }

    }
}
