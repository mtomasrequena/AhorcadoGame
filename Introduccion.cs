using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoGame
{
    class Introduccion
    {
        /*private string nombre;*/

        public Introduccion()
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            /*this.nombre = nombre;*/

            Console.Clear();

            Console.WriteLine("Bienvenido {0}", nombre);

            // si quieren dejamos aca

            new Jugador(nombre); // Inconveniente, no se le puede asignar a un objeto jugador en concreto, nos quedamos sin referencia de objeto.
        }

        /*public string getNombre()
        {
            return this.nombre;
        }*/
    }
}
