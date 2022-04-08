using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2LINQ
{
    public class Alumno
    {
        private int Edad { get; }
        private int Nota { get; }
        private string Nombre { get; }

        public Alumno(string _nombre, int _edad, int _nota)
        {
            this.Nombre = _nombre;
            this.Edad = _edad;
            this.Nota = _nota;

        }

        public Alumno()
        {

        }


        public int edad { get => edad; set => edad = value; }
        public int nota { get => nota; set => nota = value; }
        public int nombre { get => nombre; set => nombre = value; }

    }

}
