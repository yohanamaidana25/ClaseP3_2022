using System;
using System.Collections.Generic;
using System.Linq;


namespace Practico2LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practico2
            //cargamos nuestra lista de enteros con 100 numeros aleatorios utilizando el randomizador(manera 1)
            Random randomizador = new Random();
            var numeroAleatorio = randomizador.Next(1, 101);
            List<int> coleccionNumeros = new List<int>();


            for (int numero = 0; numero < 100; numero++)
            {
                coleccionNumeros.Add(numero);

            }


            //cargamos nuestra lista de enteros con 100 numeros aleatorios utilizando el randomizador(manera 2)
            /*
             
               Random randomizador = new Random();
               var numeroAleatorio = new List();

            for (int numero = 0; numero < 100; numero++)
            {
                coleccionNumeros.Add(randomizador.Next(1, 101));

            }
             */
            //ejercicio A
            int primero = coleccionNumeros.FirstOrDefault();

            //manera 1 de imprimir
            foreach (var numero in coleccionNumeros)
            {
                Console.WriteLine(numero);
            }

            //manera 2 de imprimir
            //Console.WriteLine($"el primer numero de la coleccion es {numero}");

            //ejercicio B
            int ultimo = coleccionNumeros.LastOrDefault();
            foreach (var numero in coleccionNumeros)
            {
                Console.WriteLine(numero);
            }

            //ejercicio C

            var divisiblesEntreTres = coleccionNumeros.Where(numeroAleatorio => numeroAleatorio % 3 == 0).ToList();
            foreach (var numero in divisiblesEntreTres)
            {
                Console.WriteLine(numero);
            }

            //ejercicio D
            var SumaTotal = coleccionNumeros.Sum();
            foreach (var Numero in coleccionNumeros)
            {
                Console.WriteLine(Numero);
            }

            //Ejercicio E
            var valorMaximo = coleccionNumeros.Max();
            foreach (var numero in coleccionNumeros)
            {
                Console.WriteLine(numero);
            }

            //ejercicio F
            var valorMinimo = coleccionNumeros.Min();
            foreach (var numero in coleccionNumeros)
            {
                Console.WriteLine(numero);
            }

            //ejercicio G
            List<int> numerosCuadrados = new List<int>();
            var numeroCudrado = coleccionNumeros.Select(numeroAleatorio => numeroAleatorio * numeroAleatorio).ToList();

            foreach (var cuadrado in numeroCudrado)
            {
                Console.WriteLine(cuadrado);
            }
            
            //ejercicio H
            List<int> numerosMayoresACincuenta = new List<int>();
            var mayoresACincuenta = coleccionNumeros.Where(numeroAleatorio => numeroAleatorio > 50).ToList();

            foreach(var mayoresCincuenta in mayoresACincuenta)
            {
                Console.WriteLine(mayoresCincuenta);
            }

            //ejercicio I
            var promedio = mayoresACincuenta.Average();
                Console.WriteLine(promedio);
            

            //ejercicio J
            var numerosDescendentes = coleccionNumeros.OrderByDescending(numeroAleatorio => numeroAleatorio);
            foreach (var numero in numerosDescendentes)
            {
                Console.WriteLine(numero);
            }

            //ejercicio K

            var numerosAscendentes = coleccionNumeros.OrderBy(numeroAleatorio => numeroAleatorio).ToList();
            foreach (var numero in numerosAscendentes)
            {
                Console.WriteLine(numero);
            }

            //ejercicio L
            var numerosSinRepetir = coleccionNumeros.Distinct().ToList();
            foreach (var numero in numerosSinRepetir)
            {
                Console.WriteLine(numero);
            }

            //ejercicio M
            var sumaDeNumerosUnicos = numerosSinRepetir.Sum();
            foreach (var numero in coleccionNumeros)
            {
                Console.WriteLine(sumaDeNumerosUnicos);
            }

            //ejercicio N

            var numeroCincuenta = coleccionNumeros.Any(numeroAleatorio => numeroAleatorio == 50);
            
            
            //manera 1
            //Console.WriteLine(numeroCincuenta ? "SI" : "NO");
            //manera 2
            if (numeroCincuenta == true)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }



            //ejercicio O
            var primerosTreintaYTres = coleccionNumeros.Take(33).ToList();
            foreach (var numero in primerosTreintaYTres)
            {
                Console.WriteLine(numero);
            }

            //ejercicio P
            var ultimosVeinte = coleccionNumeros.TakeLast(20).ToList();
            foreach (var numero in ultimosVeinte)
            {
                Console.WriteLine(numero);
            }

            //ejercicio Q
            var mayoresAUno = coleccionNumeros.All(numeroAleatorio => numeroAleatorio > 1);
            //Console.WriteLine(mayoresAUno ? "SI" : "NO");
            if (mayoresAUno == true)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }


            //ejercicio R

            var vecesQueSeEncuentraUnNumero = coleccionNumeros.GroupBy(numeroAleatorio => numeroAleatorio).ToList();

            foreach (var GrupoDeNumero in vecesQueSeEncuentraUnNumero)
            {

                Console.WriteLine($"El numero {GrupoDeNumero.Key}, está {GrupoDeNumero.Count()}");
               
            }

            //*********************************************************************************************************
            //PARTE 2 DE PRÁCTICO 2

            //  List<Alumno> ListaDeAlumnos = new List<Alumno>();
            Alumno alumnos = new Alumno();
            List<Alumno> ListaDeAlumnos = new List<Alumno>()
            {
            new Alumno("Eva",20,6),
            new Alumno("Ana",22,7),
            new Alumno("Rosa",22,5),
            new Alumno("Ricardo", 30, 9),
            new Alumno("Felipe", 45, 2),
            new Alumno("Pepe", 19, 3),
            new Alumno("Laia", 26, 10),
            new Alumno("Stephanie", 33, 6),
            new Alumno("Agustin", 50, 7),
            new Alumno("Mauricio", 31, 12)

            };


            //ejercicio A
            var alumnoConMayorNota = ListaDeAlumnos.OrderByDescending(alumnos => alumnos.getNota()).FirstOrDefault();
            
            
                Console.WriteLine($"El alumno con mayor nota es{alumnoConMayorNota.getNombre()}");


            //ejercicio B
            var alumnoMasJoven = ListaDeAlumnos.OrderBy(alumnos => alumnos.getEdad()).FirstOrDefault();

            Console.WriteLine($"El alumno mas joven es{alumnoMasJoven.getNombre()}");
           
            
            //ejercici C
            var promedioEnEdadDeLosAlumnos = ListaDeAlumnos.Average(alumnos => alumnos.getEdad());
          
                Console.WriteLine($"El promedio de alumnos es,{promedioEnEdadDeLosAlumnos}");
          

            //ejercicio D
            var alumnoReprobado = ListaDeAlumnos.Any(alumnos => alumnos.getNota() < 6);
          
                Console.WriteLine(alumnoReprobado ? "SI" : "NO");
          

            //ejercicio E

            var alumnosMayoresATreintaAprobados = ListaDeAlumnos.Where(alumnos => alumnos.getNota() >= 6 && alumnos.getEdad() > 30).ToList();
            foreach (var alumno in ListaDeAlumnos)
            {
                Console.WriteLine(alumnosMayoresATreintaAprobados);
            }

            //ejercicio F

            var agruparAprobados = ListaDeAlumnos.Where(alumnos => alumnos.getNota() >= 6).ToList();
            var agruparSuspendidos = ListaDeAlumnos.Where(alumnos => alumnos.getNota() < 6).ToList();
            //hay que hacer dos foreach diferentes para cada uno de los wheres anteriores
            foreach (var alumno in ListaDeAlumnos)
            {
                Console.WriteLine("Alumnos aprobados: " + agruparAprobados + "" + "Alumnos suspendidos: " + agruparSuspendidos);
            }

            //ejercicio G
            var nombreMasLargo = ListaDeAlumnos.OrderByDescending(alumnos => alumnos.getNombre().Length).ToList();

            foreach ( var largoDeNombre in nombreMasLargo)
            {
                Console.WriteLine(largoDeNombre);
            }

            //ejercicio H
            var agrupadosPorLongitudDeNombre = ListaDeAlumnos.GroupBy(alumnos => alumnos.getNombre().Length).Where(EdadDeAlumnos => EdadDeAlumnos.Sum(sumaDeEdades => sumaDeEdades.getEdad()) > 60).ToList();
            foreach (var grupoAlumnos in agrupadosPorLongitudDeNombre)
            {
                var nombres = grupoAlumnos.ToList().Select(alumno => alumno.getNombre().ToList());
                string nombreAlumno = string.Join("-",nombres);
                Console.WriteLine($"Los alumnos mayores a 60 son{ nombreAlumno}");
            }

            //ejercicio I

            var alumnosOrdenados = ListaDeAlumnos.OrderBy(ordenPorNombre => ordenPorNombre.getNombre().Length).ThenByDescending(ordenPorEdad => ordenPorEdad.getEdad()).ToList();
            foreach (var ordenEnNombreYEdadDeAlumnos in alumnosOrdenados)
            {
                Console.WriteLine(alumnosOrdenados);
            }


            //************************************************************************************
            //PARTE 3

            List<Libro> Libros = new List<Libro>()
            {
                new Libro("Don Quijote de la Mancha", 1, 1605, 500),
                new Libro("Historia de dos ciudades", 2, 1859, 200),
                new Libro("El señor de los anillos", 3, 1978, 150),
                new Libro("El principito", 4, 1951, 140),
                new Libro("El hobbit", 3, 1982, 100),
                new Libro("Sueño en el pabelón rojo", 5, 1792, 100),
                new Libro("LAs aaventuras de alicia en el pais de las Maravillas", 6, 1865, 100),
                new Libro("El codigo Da Vinci", 9, 2003, 80),
                new Libro("El guardian entre el centeno", 10, 1951, 65),
                new Libro("El alquimista", 11, 1988, 65),
            };

            List<Autor> Autores = new List<Autor>()

            {
                new Autor(1,"Miguel de Cervantes"),
                new Autor(2, "Charles Dickens"),
                new Autor(3, "J.R.R Rolkien"),
                new Autor(4, "Antonie de Sanit-Exupéry"),
                new Autor(5, "Cao Xuequin"),
                new Autor(6, "Lewis Car"),
                new Autor(7, "Agatha Christie"),
                new Autor(8, "C.S. Lewis"),
                new Autor(9, "J.D. Salinger"),
            };

            //ejercicio A
            var librosConMasVentas = Libros.OrderByDescending(libros => libros.cantidadDeVentas).Take(3).ToList();

            foreach (var librosMasVendidos in librosConMasVentas)
            {
                Console.WriteLine(librosConMasVentas);
            }

            //ejercicio B
            var librosConMenosVentas = Libros.OrderBy(libros => libros.cantidadDeVentas).Take(3).ToList();

            foreach (var librosMasVendidos in librosConMenosVentas)
            {
                Console.WriteLine(librosConMenosVentas);
            }

            //ejercicio C
            var librosConMenosDeCincuentaAnios = Libros.Where(libro => DateTime.Now.Year - libro.anioPublicacion < 50).ToList();
            foreach (var libros in librosConMenosDeCincuentaAnios)
            {
                Console.WriteLine(librosConMenosDeCincuentaAnios);
            }
            
            //ejercicio D
            var libroMasViejo = Libros.OrderBy(libro => libro.anioPublicacion).FirstOrDefault();
           
                Console.WriteLine(libroMasViejo.titulo);
            

            //ejercicio E

            var librosPorNombre = Libros.Join(Autores,
                                    libro => libro.idAutor,
                                    autor => autor.idAutor,
                                    (libro, autor) => new { NombreAutor = autor.nombre, Titulo = libro.titulo }).ToList();

            var librosQueComiencenConEl = librosPorNombre.Where(libroConEl => libroConEl.Titulo.StartsWith("El")).Select(autor => autor.NombreAutor).Distinct().ToList();

            foreach(var libros in librosQueComiencenConEl)
            {
                Console.WriteLine(libros.);
}
            //ejercicio F
            var VentasDeAutor = Libros.Join(Autores,
                                libro => libro.idAutor,
                                autor => autor.idAutor,
                                (libro, autor) => new { NombreAutor = autor.nombre, IdAutor = autor.idAutor }).ToList();
            var autorConMasLirosPublicados = VentasDeAutor.GroupBy(autor => autor.NombreAutor).OrderByDescending(libro => libro.Count()).FirstOrDefault();

         
                Console.WriteLine(VentasDeAutor.Key);
            

            //ejercicio G
            //sin resolver
            var autorYLibrosQuePublico = Libros.Join(Autores,
                                         libro => libro.idAutor,
                                         autor => autor.idAutor,
                                         (libro, autor) => new {NombreAutor = autor.nombre, IDAutor = autor.idAutor}).ToList();
         
            var grupoAutorConMasLibrosPblicados = autorYLibrosQuePublico.GroupBy(autor => autor.NombreAutor).OrderByDescending(libro => libro.Count()).FirstOrDefault();
            Console.WriteLine(VentasDeAutor.Key);


        }
    }
}


