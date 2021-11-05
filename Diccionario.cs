using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoGame
{
    class Diccionario
    {
        private string[] diccionario = { "Marcos", "Leandro", "Jerkan", "ElizabethRiendo", "Matias", "chancleta", "juanjo", "coqueluche" };

        public string generarPalabra()
        {
            Random posicionRandom = new Random();
            int posicion = posicionRandom.Next(0, diccionario.Length - 1);
            return diccionario[posicion];
        }
    }
}
