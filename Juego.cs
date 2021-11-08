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
        
        private void convertirGuion()
        {
            palabrachar = palabra.ToLower().ToCharArray();
            enigma = palabra.ToCharArray();
            for (int i = 0; i < enigma.Length; i++)
                enigma[i] = '_';
        }

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
