//Esto resuelve el algoritmo 1 de la hoja de trabajo
// Seccion A
using System.Globalization;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //code here..
        int a,b;
        double r; 
        const int exponent = 2;

        Console.WriteLine("Ingrese el valor de a: ");
        a = Convert.ToInt32(Console.ReadLine()); // La conversion verifica que solo permita numeros

        Console.WriteLine("Ingrese el valor de b: ");
        b = Convert.ToInt32(Console.ReadLine()); //// La conversion verifica que solo permita numeros

        if (a==0){
            Console.WriteLine("Usted ha ingresando un valor incorrecto");
        }
        else{
            r = (Math.Pow((a+b),exponent))/(3*a);
            Console.WriteLine("El resultado de la operacion es: " + r);
        }
    }
}