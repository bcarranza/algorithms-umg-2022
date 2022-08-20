/*
Autor: Bayron Carranza
Github: bayron.carranza
Descripción: Determina si un numero es par o impar usando MOD
% = MOD
*/

using System;
internal class Program
{   
    private static void Main(string[] args)
    {
      int num;
      Console.WriteLine("Ingresar un numero par/impar: ");
      num = Convert.ToInt32(Console.ReadLine());

      if(num % 2 == 0){
        Console.WriteLine("El numero " + num + " es par");
      }
      else{
        Console.WriteLine("El numero " + num + " es impar");
      }
    }
}