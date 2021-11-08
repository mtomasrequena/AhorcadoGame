using System;

namespace AhorcadoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduccion introduccion = new Introduccion();

            Jugador jugador1 = new Jugador(introduccion.getNombre());

            new Juego(jugador1);
        }
    }
}