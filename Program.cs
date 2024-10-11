using System;


namespace Testing1{
    class Program{
        

        static void Main (string[] args){
            
            //VARIABLES

            int valor_1, valor_2, valor_3, valor_4;
            float operacion_1,operacion_2,operacion_3, operacion_4;
            Boolean compara_1,compara_2,compara_3,compara_4,compara_5,compara_6;

            //INGRESO DE VALORES 

            System.Console.WriteLine("Ingrese el valor del primer dato. ");
            valor_1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el valor del segundo dato. ");
            valor_2=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el valor del tercer dato. ");
            valor_3=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese el valor del cuarto dato. ");
            valor_4=int.Parse(Console.ReadLine());
            
/*
INSTRUCCIONES DE CANVAS
4.-
Suma los 4 números y guarda el resultado en la variable operación_1.
Multiplica los 4 valores dados y guarda el resultado en la variable operación_2.
Divide valor_1 entre valor_2 y suma valor_3 entre valor_4, guardando el resultado en operación _3.
Divide operación _1 entre operación _2 y guárdalo en operación_4.
*/
            operacion_1=valor_1+valor_2+valor_3+valor_4;
            operacion_2=valor_1*valor_2*valor_3*valor_4;
            operacion_3=((valor_1/valor_2)+(valor_3/valor_4));
            operacion_4= operacion_1/operacion_2;
            System.Console.WriteLine();
            System.Console.WriteLine();
            //RESULTADOS

            System.Console.WriteLine("OPERACIÓN 1");
            System.Console.WriteLine("Sumar los 4 numeros da: "+operacion_1);
            System.Console.WriteLine("OPERACIÓN 2");
            System.Console.WriteLine("Multiplicar los 4 numeros da: "+operacion_2);
            System.Console.WriteLine("OPERACIÓN 3");
            System.Console.WriteLine("Dividir los primeros dos numeros y posteriormente sumarselo a los últimos dos numeros divididos entre ellos da: "+operacion_3);
            System.Console.WriteLine("OPERACIÓN 4");
            System.Console.WriteLine("Dividir la el resultado de la operación 1 entre la 2 da: "+operacion_4);
            System.Console.WriteLine();
            System.Console.WriteLine();
/*
INSTRUCCIONES DE CANVAS
5.-
Con los datos iniciales realiza las siguientes operaciones lógicas:

Verifica si valor_1 es distinto a valor_3 y guarda el resultado en la variable compara_1.
Verifica si valor_2 es igual a valor_4 y guarda el resultado en la variable compara_2.
Verifica si valor_1 es mayor que valor_3 o valor_4 y guarda el resultado en compara_3.
Verifica si valor_2 es menor que operación_3 y guarda el resultado en compara_4.
Verifica si compara_1 y compara_2 se cumplen y guarda el resultado en compara_5.
Verifica si compara_3 o compara_4 se cumplen y lo guarda en compara_6.
*/

                //Verifica si valor_1 es distinto a valor_3 y guarda el resultado en la variable compara_1.
            if(valor_1!=valor_3){
                compara_1=true;
            }else{
                compara_1=false;
            }

                //Verifica si valor_2 es igual a valor_4 y guarda el resultado en la variable compara_2.
            if(valor_2==valor_4){
                compara_2=true;
            }else{
                compara_2=false;
            }

                //Verifica si valor_1 es mayor que valor_3 o valor_4 y guarda el resultado en compara_3.
            if(valor_1>valor_3 || valor_1>valor_4){
                compara_3=true;
            }else{
                compara_3=false;
            }

                //Verifica si valor_2 es menor que operación_3 y guarda el resultado en compara_4.
            if(valor_2<operacion_3){
                compara_4=true;
            }else{
                compara_4=false;
            }

                //Verifica si compara_1 y compara_2 se cumplen y guarda el resultado en compara_5.
            if(compara_1==true && compara_2==true){
                compara_5=true;
            }else{
                compara_5=false;
            }

                //Verifica si compara_3 o compara_4 se cumplen y lo guarda en compara_6.
            if(compara_3==true || compara_4==true){
                compara_6=true;
            }else{
                compara_6=false;
            }

            System.Console.WriteLine("El primer y el tercer valor son distintos? "+compara_1);
            System.Console.WriteLine("El segundo y el cuarto valor son iguales? "+compara_2);
            System.Console.WriteLine("El primer valor es mayor que el tercer valor o el cuarto? "+compara_3);
            System.Console.WriteLine("El segundo valor es menor que el resultado de la operacion 3? "+compara_4);
            System.Console.WriteLine("El primer comparador y el segundo se cumplen? "+compara_5);
            System.Console.WriteLine("El segundo comparador o el tercero se cumplen? "+compara_6);
                

        }
    }
}