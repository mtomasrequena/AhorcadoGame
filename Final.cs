using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoGame
{
    class Final
    {
        public Final(Jugador jugador1, string palabra)
        {
            Console.Clear();
            if (jugador1.tieneVidas())
            {
                Console.WriteLine("\nFelicidades {0}, no has sido colgado!\n", jugador1.getNombre());
            }
            else
            {
                Console.WriteLine("\n{0} has sido colgado!\n", jugador1.getNombre());
                Console.WriteLine("\nLa palabra era: {0}", palabra);
            }
            Console.ReadKey();
            Console.WriteLine("\n¿Quieres volver a jugar?\n\nIngrese si/no: ");
            string resp = Console.ReadLine().ToLower();
            while(verificarResp(resp))
            {
                Console.WriteLine("\nIngreso no valido.");
                Console.WriteLine("\n¿Quieres volver a jugar?\n\nIngrese si/no: ");
                resp = Console.ReadLine().ToLower();
            }
            if (resp == "si")
                reiniciarJuego(jugador1.getNombre());
            else
                Console.WriteLine("\nProgama terminado.\n");
        }

        private bool verificarResp(string resp)
        {
            if (resp == "si" || resp == "no")
            {
                return false;
            }
            else
                return true;
        }

        private void reiniciarJuego(string name)
        {
            Console.Clear();
            Jugador j1 = new Jugador(name);
            new Juego(j1);
        }
    }
}
