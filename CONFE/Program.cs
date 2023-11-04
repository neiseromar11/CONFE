using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Clase;
namespace CONFE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] velocidadEnMillas = { 20f, 40f, 60f, 80f, 100f, 120f, 140f, 160f, 180f, 200f };
            float[] frecuencia = { 149.34f, 298.69f, 448.03f, 597.37f, 746.71f, 896.06f, 1045.40f, 1194.74f, 1344.09f, 1493.43f };
            float[] velocidadEnKilometros = new float[10];

           Bibliotecas.CabeceraPantalla(velocidadEnMillas, frecuencia, velocidadEnKilometros);

            float velocidadMinima = velocidadEnKilometros[0];
            float velocidadMaxima = velocidadEnKilometros[0];

            for (int i = 1; i < velocidadEnKilometros.Length; i++)
            {
                if (velocidadEnKilometros[i] < velocidadMinima)
                {
                    velocidadMinima = velocidadEnKilometros[i];
                }
                if (velocidadEnKilometros[i] > velocidadMaxima)
                {
                    velocidadMaxima = velocidadEnKilometros[i];
                }
            }

            Bibliotecas.PIe_Pag(velocidadEnKilometros, velocidadMinima, velocidadMaxima);
            Console.ReadKey();
        }

    }
}
