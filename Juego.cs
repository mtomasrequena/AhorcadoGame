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

        char[] enigma, palabrachar;
        bool letraVerdadera=false;
        
        private void convertirGuion()
        {
            palabrachar = palabra.ToLower().ToCharArray();
            enigma = palabra.ToCharArray();
            for (int i = 0; i < enigma.Length; i++)
                enigma[i] = '_';
        }

        public Juego()
        {
            asignarPalabra();

            convertirGuion();

            mostrarEnigma();

            Console.WriteLine("Ingrese letra: ");
            char letra = char.Parse(Console.ReadLine());

            compararLetra(letra);
            Console.Clear();
            Console.WriteLine(letraVerdadera.ToString());

            mostrarEnigma();
        }

        private void compararLetra(char letra)
        {
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
            for(int i=0;i<enigma.Length;i++)
            {
                Console.Write(enigma[i].ToString() + " ");
            }
        }

        public void asignarPalabra()
        {
            Diccionario palabraElegida = new Diccionario();
            this.palabra = palabraElegida.generarPalabra();
        }
    }
}
