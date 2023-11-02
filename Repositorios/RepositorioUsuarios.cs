using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBibliotecaria.Modelo;

namespace GestionBibliotecaria.Repositorios
{
    public class RepositorioUsuarios
    {
        public List<Usuario> Usuarios { get; set; }
        public RepositorioUsuarios()
        {
            Usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            bool existe = Usuarios.Any(u => u.Id == usuario.Id);
            if (!existe)
            {
                Usuarios.Add(usuario);
                Console.WriteLine("Se agrego un usuario exitosamente");
            }
            else
            {
                Console.WriteLine("Ya existe un usuario con ese id");
            }
           
        }
        public bool EliminarUsuario(int id)
        {
            Usuario eliminarUsuario = Usuarios.FirstOrDefault(identificacion => identificacion.Id == id);
            if (eliminarUsuario != null)
            {
                Usuarios.Remove(eliminarUsuario);
                Console.WriteLine($"El usuario con el ID {id} fue eliminado");
                return true;
            }
            else
            {
                Console.WriteLine($"No se encontro ningun usuario con el numero de ID {id}");
                return false;
            }
        }

        public bool ModificarUsuario(int id, string nombre, string apellidos, string correo)
        {
            Usuario modificarUsuario = Usuarios.FirstOrDefault(identificacion => identificacion.Id == id);
            if (modificarUsuario != null)
            {
                modificarUsuario.Nombre = nombre;
                modificarUsuario.Apellido = apellidos;
                modificarUsuario.Correo = correo;
                Console.WriteLine("EL usuario fue modificado exitosamente");
                return true;
            }
            else
            {
                Console.WriteLine($"El id numero {id} no fue encontrado");
                return false;
            }
        }

        public void MostrarUsuario()
        {
            Console.WriteLine("Lista de usuarios");
            foreach (var usuario in Usuarios)
            {
                usuario.InformacionUsuario();
                Console.WriteLine();
            }
        }

    }
}
