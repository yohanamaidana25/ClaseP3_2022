using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2LINQ
{
    public class Libro
    {
        private int AnioPublicacion;
        private int CantidadDeVentas;
        private int IdAutor;
        private string Titulo;
        
        public int anioPublicacion { get => anioPublicacion; set => anioPublicacion = value; }
        public int cantidadDeVentas { get => CantidadDeVentas; set => CantidadDeVentas= value; }
        public int idAutor { get => idAutor; set => idAutor= value; }
        public string titulo { get => titulo; set => titulo = value; }

        public Libro(string _titulo, int _idAutor, int _anioPublicacion, int _cantidadDeVentas)
        {
            this.Titulo = _titulo;
            this.IdAutor = _idAutor;
            this.AnioPublicacion = _anioPublicacion;
            this.CantidadDeVentas = _cantidadDeVentas;
        }
        public Libro()
        {

        }

        
    }
}
