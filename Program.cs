using System;

namespace Practica_Biblioteca___CLase_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libroUno = new Libro("The Selfish Gene", "Richard Dawkins", 5);
            Libro libroDos = new Libro("The God Delusion", "Richard Dawkins", 5);
            Libro libroTres = new Libro("On The Origin of Species", "Charles Darwin", 5);
            Libro libroCuatro = new Libro("Pale Blue Dot: A Vision of the Human Future in Space", "Carl Sagan", 5);
            Libro libroCinco = new Libro("Animal Liberation", "Peter Singer", 5);
            Libro libroSeis = new Libro("The Life You Can Save", "Peter Singer", 5);
            Libro libroSiete = new Libro();
            libroSiete.Titulo = "The Most Good You Can Do: How Effective Altruism Is Changing Ideas About Living Ethically";
            libroSiete.Autor = "Peter Singer";
            libroSiete.CantidadCopias = 5;
            Libro libroOcho = new Libro();
            libroOcho.Titulo  = "The Classical Utilitarians";
            libroOcho.Autor = "Jeremy Bentham";
            libroOcho.CantidadCopias = 5;

            libroSiete.Prestar();
            libroSiete.Prestar();
            libroSiete.Prestar();
            libroSiete.Prestar();
            libroSiete.Prestar();
            libroSiete.Prestar();
            Console.WriteLine("\r\n");
            libroSiete.MostrarLibro();
            libroSiete.Prestar();
            libroSiete.Prestar();
            libroSiete.MostrarLibro();
            libroSiete.Devolver();
            libroSiete.Devolver();
            libroSiete.Devolver();
            libroSiete.Devolver();
            libroSiete.Devolver();
            libroSiete.Devolver();
            libroSiete.Devolver();
            libroSiete.MostrarLibro();
            libroSiete.Devolver();
            libroSiete.Devolver();
            libroSiete.MostrarLibro();
        }
    }
}

/* 
    EJERCICIOS 1

    • Crear una clase llamada Libro que almacene la información de cada uno de los 
    libros en una biblioteca. La clase debe conservar el título del libro, el autor, el 
    número de copias del libro y el número de copias en préstamo.

    • La clase contendrá los siguientes métodos: constructor predeterminado. 
    Constructor con parámetros.

    • Método Prestar que aumenta el atributo correspondiente cada vez que se realiza 
    un préstamo a partir del libro. No se pueden pedir prestados libros si no hay 
    copias disponibles para prestar. Devuelve true si la operación se realizó 
    correctamente y false en caso contrario.

    • Método Devolver que disminuye el atributo correspondiente cuando se devuelve 
    un libro. No se pueden devolver libros que no hayan sido prestados. Devuelve 
    true si la operación se realizó correctamente y false en caso contrario.

    • Nuevo método para mostrar datos de libros.

    • Escriba un programa para probar el funcionamiento de la clase Libro.
*/