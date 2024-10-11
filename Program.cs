
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Testing{
class Program12{
static void Main(string[] args){
     double y, yy, yyy ;
        double x = 0, paso = 0.01;            
        double k1, k2, k3, k4;
               

        y=1;            

        yy = 2;            

        while (x < 2)
        {
            yyy = Math.Pow(((3*x) +5),(1/2));
               
            y = y + yy * paso+yyy*paso*paso;                

            yy = yy + yyy * paso;                

            x = x + paso;            
        }            

        Console.WriteLine("El valor de y cuando x es " + x + " es " + y);

        y = 1;              

        while (x < 12)
        {
       
            k1 = (-Math.Sin(x)+((5*y)*(Math.Cos(x))));                

            
            k2 = (-Math.Sin(x)+((5*y*0.5*k1*paso)*(0.5*paso*Math.Cos(x))));              
           
            k3 = (-Math.Sin(x)+((5*y*0.5*k2*paso)*(0.5*paso*Math.Cos(x))));   
                  
            k4 = (-Math.Sin(x)+((5*y*0.5*k3*paso)*(0.5*paso*Math.Cos(x)))); 
            y = y + (k1 + 2 * k2 + 2 * k3 + k4)*paso/6;                

            x = x + paso;                

            Console.WriteLine(x);
        }            

        Console.WriteLine("El valor de y cuando x es " + x + " es " + y);
                       
        Console.ReadLine();}
}
}
