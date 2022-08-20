/*
Autor: Bayron Carranza
Github: bayron.carranza
Descripción: Aplicacion de estructura selectiva multiple.
*/

using System;
internal class Program
{   
    private static void Main(string[] args)
    {
        int num;
        int valor;
        int result;
        Console.WriteLine("Escribe un numero");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe un valor");
        valor = Convert.ToInt32(Console.ReadLine());

        switch(num) 
        {
            case 1:
                result = 100*valor;
                break;
            case 2:
                result = 100*valor*valor;
                break;
            case 3:
                result = 100/valor;
                break;
            default:
                result = 0;
                break;
        }
        Console.WriteLine("Resultado " + result);
    }
}