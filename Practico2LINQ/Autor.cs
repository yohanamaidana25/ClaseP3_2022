using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2LINQ
{
    public class Autor
    {
        private int IdAutor;
        private string Nombre;

        public Autor(int _idAutor, string _nombre)
        {
            this.idAutor = _idAutor;
            this.nombre = _nombre;
        }

      
        public int idAutor { get => IdAutor; set => IdAutor = value; }
        public string nombre { get => Nombre; set => Nombre = value; }

        
    }
}
