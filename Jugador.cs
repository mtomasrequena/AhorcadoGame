using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoGame
{
    class Jugador
    {
        private string nombre;
        private int vidas = 6;

        // Sistema de puntuacion?

        public Jugador(string name)
        {
            this.nombre = name;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void quitarVidas()
        {
            this.vidas--;
        }

        public void mostrarVidas()
        {
            Console.WriteLine("Te quedan {0} vidas", this.vidas);
        }

        public bool tieneVidas()
        {
            return this.vidas > 0;
        }
    }
}
