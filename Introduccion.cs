using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoGame
{
    class Introduccion
    {
        private string nombre;

        public Introduccion()
        {
            Console.WriteLine("Ingrese su nombre");
            this.nombre = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nBienvenido {0}\n", this.nombre);

            mostrarReglas();

            Console.WriteLine("\nPrecione cualquier tecla para empezar a jugar.");
            Console.ReadKey();

            Console.Clear();
        }

        public string getNombre()
        {
            return this.nombre;
        }

        private void mostrarReglas()
        {
            Console.WriteLine("REGLAS: \n");
            Console.WriteLine("- Inicias el juego con 6 vidas.");
            Console.WriteLine("- Se le mostrara una palabra oculta y deberas ingresar una letra que creas contiene la palabra.");
            Console.WriteLine("- Pierdes una vida si la letra ingresada no esta en la palabra. Si pierdes todas las vidas pierdes el juego.");
            Console.WriteLine("- Si completas la palabra, ganas el juego.");
        }
    }
}
