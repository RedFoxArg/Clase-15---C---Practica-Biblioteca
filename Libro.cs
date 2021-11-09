using System;

namespace Practica_Biblioteca___CLase_15
{
    class Libro
    {
        public string Titulo = ""; 
        public string Autor = ""; 
        public short CantidadCopias = 0; 
        public short CopiasEnPrestamo = 0; 
        public Libro()
        {

        }
        public Libro(string titulo, string autor, short cantidad)
        {
            Titulo = titulo;
            Autor = autor;
            CantidadCopias = cantidad;
        }

        public void Prestar()
        {
            if(HayDisponibles()){
                this.CopiasEnPrestamo++;
            }
        }
        public void Devolver()
        {
            if(HayPrestados()){
                this.CopiasEnPrestamo--;
            }
        }

        private bool HayPrestados()
        {
            bool puedeDevolver = false;
            if(this.CopiasEnPrestamo > 0 && this.CopiasEnPrestamo <= this.CantidadCopias){
                puedeDevolver = true;
            }
            return puedeDevolver;
        }

        private bool HayDisponibles()
        {
            bool disponible = false;
             if(this.CopiasEnPrestamo < this.CantidadCopias){
                disponible = true;
            }
            return disponible;
        }
        public void MostrarLibro()
        {
            // Centrado Encabezado
            string header = "B I B L I O T E C A  C o m I T";
            int screenWidth = Console.WindowWidth;
	        int stringWidth = header.Length;
	        int spaces = (screenWidth / 2) + (stringWidth / 2);
            // fin centrado encabezado

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(header.PadLeft(spaces));
            Console.ResetColor();
            Lineas(screenWidth);
            Console.WriteLine($"\x1B[38;5;11m   T í t u l o : \x1B[0m{this.Titulo}.\r\n\x1B[38;5;11m   A u t o r : \x1B[0m{this.Autor}.\r\n\x1B[38;5;11m   C a n t .  C o p i a s : \x1B[0m{this.CantidadCopias}.\r\n\x1B[38;5;11m   E n   p r é s t a m o :  \x1B[0m{this.CopiasEnPrestamo}.");
            /* Console.WriteLine($"\x1B[38;5;11mT í t u l o : \x1B[0m{this.Titulo.PadLeft(this.Titulo.Length + 11)}.\r\n\x1B[38;5;11mA u t o r : \x1B[0m{this.Autor.PadLeft(this.Autor.Length + 13)}.\r\n\x1B[38;5;11mC a n t .  C o p i a s : \x1B[0m{this.CantidadCopias}.\r\n\x1B[38;5;11mE n   p r é s t a m o :  \x1B[0m{this.CopiasEnPrestamo}."); */
            Lineas(screenWidth);
        }

        private void Lineas(int anchoTerminal)
        {
            Console.Write("\r\n");
            for (int i = 0; i < anchoTerminal; i++)
            {
                Console.Write("-");
            }
            Console.Write("\r\n\r\n");
        }
    }

}