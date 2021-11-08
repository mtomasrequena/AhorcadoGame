﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoGame
{
    class Juego
    {
        private Jugador jugador;
        private string palabra;
        char[] enigma, palabrachar;
        bool letraVerdadera=false;
        
        public Juego( Jugador jugador )
        {
            this.jugador = jugador;
            jugar();
        }

        public void jugar()
        {
            asignarPalabra();
            convertirGuion();

            while ( jugador.tieneVidas() && comprobarEnigma() )
            {
                mostrarEnigma();
                Console.WriteLine("\nIngrese letra: \n");
                char letra = char.Parse(Console.ReadLine());
                while (comprobarLetra(letra) == false)
                {
                    Console.WriteLine("\nNo se ha ingresado una letra\n");
                    Console.WriteLine("\nIngrese letra: \n");
                    letra = char.Parse(Console.ReadLine());
                }
                compararLetra(letra);
            }
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
            mostrarEnigma();
        }

        private void mostrarEnigma()
        {
            Console.WriteLine();
            for( int i=0; i<enigma.Length; i++ )
            {
                Console.Write( enigma[i].ToString() + " " );
            }
        }

        public void asignarPalabra()
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

        public bool comprobarEnigma()
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

        public bool comprobarLetra(char letra)
        {
            string numeros = "0 1 2 3 4 5 6 7 8 9";
            return !numeros.Contains(letra);
        }
    }
}
