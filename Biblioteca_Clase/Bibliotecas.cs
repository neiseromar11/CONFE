using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clase
{
    public class Bibliotecas
    {

        public static void PIe_Pag(float[] velocidadEnKilometros, float velocidadMinima, float velocidadMaxima)
        {
            Console.WriteLine("\nVelocidades que superan los 100 km/h:");
            for (int i = 0; i < velocidadEnKilometros.Length; i++)
            {
                if (velocidadEnKilometros[i] > 100f)
                {
                    Console.WriteLine(velocidadEnKilometros[i]);
                }
            }

            Console.WriteLine($"\nVelocidad mínima en kilómetros: {velocidadMinima:F2}");
            Console.WriteLine($"Velocidad máxima en kilómetros: {velocidadMaxima:F2}");
        }

        public static void CabeceraPantalla(float[] velocidadEnMillas, float[] frecuencia, float[] velocidadEnKilometros)
        {
            Console.WriteLine("VELOCIDAD EN MILLAS   FRECUENCIA   VELOCIDAD EN KILOMETROS");
            for (int i = 0; i < velocidadEnMillas.Length; i++)
            {
                velocidadEnKilometros[i] = velocidadEnMillas[i] * 1.60934f;
                Console.WriteLine($"{velocidadEnMillas[i],11:F2} {frecuencia[i],18:F2} {velocidadEnKilometros[i],18:F2}");
            }
        }
    }
}
