using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoGame
{
    class Juego
    {
        private Jugador jugador;
        private string palabra;
        private char[] enigma, palabrachar;
        private bool letraVerdadera = false;
        private StringBuilder registro = new StringBuilder();
        
        public Juego( Jugador jugador )
        {
            this.jugador = jugador;
            jugar();
        }

        private void jugar()
        {
            asignarPalabra();
            convertirGuion();

            while (jugador.tieneVidas() && comprobarEnigma())
            {
                mostrarEnigma();

                Console.WriteLine("\n\nIngrese letra: ");
                string letraingresada = Console.ReadLine();

                while (comprobarLetra(letraingresada) == false)
                {
                    Console.WriteLine("\nNo se ha ingresado una letra\n");
                    Console.WriteLine("\nIngrese letra: \n");
                    letraingresada = Console.ReadLine();
                }

                char letra = char.Parse(letraingresada);

                compararLetra(letra);

                Console.Clear();

                if ( letraVerdadera == false )
                {
                    Console.WriteLine("Le erraste {0}\n", jugador.getNombre());
                    jugador.quitarVidas();
                    jugador.mostrarVidas();
                }

                registrarLetra(letra);
            }
            mostrarEnigma();
            final();
        }

        private void final()
        {
            Console.Clear();
            
            if (jugador.tieneVidas())
            {
                Console.WriteLine("\nFelicidades {0}, no has sido colgado!\n", jugador.getNombre());
            }
            else
            {
                Console.WriteLine("\n{0} has sido colgado!\n", jugador.getNombre());
                Console.WriteLine("\nLa palabra era: {0}", this.palabra);
            }
            Console.ReadKey();
        }

        private void compararLetra(char letra)
        {
            letraVerdadera = false;
            for(int i = 0; i < palabrachar.Length; i++)
            {
                if(palabrachar[i]==letra)
                {
                    enigma[i] = palabrachar[i];
                    letraVerdadera = true;
                }
            }
        }

        private void mostrarEnigma()
        {
            Console.WriteLine();
            for( int i=0; i<enigma.Length; i++ )
            {
                Console.Write( enigma[i].ToString() + " " );
            }
        }

        private void asignarPalabra()
        {
            Diccionario diccionario = new Diccionario();
            this.palabra = diccionario.generarPalabra();
        }

        private void convertirGuion()
        {
            palabrachar = palabra.ToLower().ToCharArray();
            enigma = palabra.ToCharArray();
            for ( int i = 0; i < enigma.Length; i++ )
                enigma[i] = '_';
        }

        private bool comprobarEnigma()
        {
            bool estadoDelEnigma = false;

            for (int i = 0; i < palabrachar.Length; i++)
            {
                if ( enigma[i] != palabrachar[i] )
                {
                    estadoDelEnigma = true;
                }
            }
            return estadoDelEnigma;
        }

        private bool comprobarLetra(string letraingresada)
        {
            string numeros = "0 1 2 3 4 5 6 7 8 9";
            if (letraingresada.Length > 1 || numeros.Contains(letraingresada))
                return false;
            else
                return true;
        }

        private void registrarLetra(char letra)
        {
            registro.Append(letra.ToString() + " ");

            Console.WriteLine("Letras ingresadas: " + registro.ToString() + "\n");
        }
    }
}
