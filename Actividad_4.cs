using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2{
    class Program{
        static void Main (string[] args){

        // Arreglo para marcar los números compuestos
        bool[] esPrimo = new bool[1001];

        // Inicializar todos los números como primos
        for (int i = 2; i <= 1000; i++)
        {
            esPrimo[i] = true;
        }

        // Aplicar la criba de Eratóstenes
        for (int i = 2; i * i <= 1000; i++)
        {
            // Si el número actual es primo
            if (esPrimo[i])
            {
                // Marcar todos los múltiplos como compuestos
                for (int j = i * i; j <= 1000; j += i)
                {
                    esPrimo[j] = false;
                }
            }
        }

        // Mostrar los números primos encontrados
        Console.WriteLine("Números primos del 1 al 1000:");
        for (int i = 2; i <= 1000; i++)
        {
            if (esPrimo[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}
}

