using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1{
    class Program{
        static void Main (string[] args){

            int dato_usuario=1;
            int [] todos_los_datos  = new int [10];
            int contador=0, suma=0, comparador=0, repeticion=0, numero=0;
            Dictionary<int, int> frecuencia = new Dictionary<int, int>();

            
            for(int i=0; i<=10; i++){
                if(dato_usuario!=0 && dato_usuario<50){
                System.Console.WriteLine("Ingresa un dato: ");
                dato_usuario = int.Parse(Console.ReadLine());
                todos_los_datos[i] = dato_usuario;
                contador++;
                }
                
            }

            for(int i=0; i<=contador-1; i++){
                suma = suma +todos_los_datos[i];
                if(todos_los_datos[i]>comparador){
                    comparador=todos_los_datos[i];
                }
            }
            System.Console.WriteLine("Usted ingreso: "+ (contador-1)+" numeros");
           System.Console.WriteLine("Su promedio es: "+ (suma/(contador-1)));
            System.Console.WriteLine("Su numero mas grande es: "+ comparador);
            
            for(int i=0; i<=contador-1; i++){
                for(int j=0; j<=contador-1; j++){
                    
                    if(todos_los_datos[i]==todos_los_datos[j] && i!=j){

                    repeticion++;
                    numero=todos_los_datos[i];
                    }

                }
            } 
            for(int i = 0; i<contador-1; i++){
              if (frecuencia.ContainsKey(numero))
                {
                frecuencia[numero]++;
                }
                else
                {
                frecuencia[numero] = 1;
                }
            }


        // Encontrar el número con la mayor frecuencia (la moda)
        int moda = 0;
        int maxFrecuencia = 0;
        foreach (var par in frecuencia)
        {
            if (par.Value > maxFrecuencia)
            {
                moda = par.Key;
                maxFrecuencia = par.Value;
            }
        }
            System.Console.WriteLine("Su moda es: "+ moda);           
        }
    }
}
