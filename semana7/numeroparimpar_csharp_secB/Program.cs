
/*
Autor: Bayron Carranza
Github: bayron.carranza
Descripción: Determina si un numero es par o impar utilizando el operador MOD
*/

using System;
internal class Program
{   
    private static void Main(string[] args)
    {
        int numParImpar;
        Console.WriteLine("Ingrese un numero");
        numParImpar = Convert.ToInt32(Console.ReadLine());

        if(numParImpar % 2 == 0)
        {
            Console.WriteLine("El numero " + numParImpar + " es par" );
        }
        else
        {
            Console.WriteLine("El numero " + numParImpar + " es impar" );
        }
    }
}