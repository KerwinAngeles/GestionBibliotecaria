using GestionBibliotecaria.Modelo;
using GestionBibliotecaria.Repositorios;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Security.Cryptography.X509Certificates;

namespace GestionBibliotecaria
{
    class MyClass
    {
        static void Main (string[] args)
        {
            Menu menu = new Menu();
            bool seleccion = true;
            
            while (seleccion)
            {
                Console.WriteLine(
                "\n 1: Gestionar Libros " +
                "\n 2: Gestionar Usuarios " +
                "\n 3: Prestar Libros " +
                "\n 4: Devolver Libros " +
                "\n 5: Mostrar Libros Prestados " +
                "\n 6: Mostrar Libros Disponibles " +
                "\n 7: Mostrar Usuarios " +
                "\n 8: Salir");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        menu.GestionarLibros();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        menu.GestionarUsuarios();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        menu.Prestamos();
                        break;
                    case 4:
                        Console.Clear();
                        menu.Devolver();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        menu.LibrosPrestados();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        menu.MostrarLibros();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        menu.MostrarUsuarios();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Muchas gracias.");
                        seleccion = false;
                        break;           
                }
            }    
        }
    }
}

