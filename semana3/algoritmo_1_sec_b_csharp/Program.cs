//Este programa resuelve el algoritmo 1 de la hoja de trabajo semana 3.

using System.Globalization;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //code here!!!
        ////Seccion de definicion de variables
        int a,b;
        double result;

        ////Solicitud de valores al usuario (incluye la lectura de los mismos)
        Console.WriteLine("Ingrese el valor de a");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de b");
        b = Convert.ToInt32(Console.ReadLine());

        //Validacion de la operacion indefinida
        if(a>0){
            result =  (Math.Pow((a+b),2))/(3*a);
            Console.WriteLine("El resultado de la operacion es: " + result);
        }
        else
            Console.WriteLine("Esta operacion no es correcta debido a que no existe en el conjunto de los reales.");
    }
}