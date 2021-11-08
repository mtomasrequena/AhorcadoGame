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

            Console.WriteLine("Bienvenido {0}", this.nombre);

            // si quieren dejamos aca

            
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public Introduccion GetIntroduccion()
        {
            Introduccion j1 = new Introduccion();
            return j1;
        }
    }
}
