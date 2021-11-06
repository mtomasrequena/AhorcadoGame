using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoGame
{
    class Juego
    {
        private string palabra;
        /*private Jugador jugador;

        public Juego(Jugador jugador)
        {
            this.jugador = jugador;
        }*/

        public void jugar()
        {
            asignarPalabra();
        }

        public void mostrarReglas()
        {
            Console.WriteLine("Reglas y cosas varias");
        }

        public void asignarPalabra()
        {
            Diccionario palabraElegida = new Diccionario();
            this.palabra = palabraElegida.generarPalabra();
        }
    }
}
