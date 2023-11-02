using GestionBibliotecaria.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotecaria.Modelo
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Author { get; set; }
        public DateTime AnoPublicacion { get; set; }

        public Libro() 
        {
            
        }

        public Libro(int idLibro, string titulo, string genero, string author, DateTime anoPublicacion)
        {
            IdLibro = idLibro;
            Titulo = titulo;
            Genero = genero;
            Author = author;
            AnoPublicacion = anoPublicacion;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Id: {IdLibro}");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"authro: {Author}");
            Console.WriteLine($"Año Publicación: {AnoPublicacion}");
        }
    }
}
