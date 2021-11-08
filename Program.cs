using System;

namespace AhorcadoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduccion j1 = new Introduccion();
            
            Jugador jugador = new Jugador(j1.getNombre()); // new Jugador(Jugador player)

            new Juego(j1,jugador);
        }
    }
}
