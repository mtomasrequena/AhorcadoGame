using System;

namespace AhorcadoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduccion pepito = new Introduccion();
            
            Jugador jugador = new Jugador(pepito.getNombre());

            new Juego(jugador);
        }
    }
}
