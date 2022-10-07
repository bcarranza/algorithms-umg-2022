//docs: https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/file-io-operation

using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        // Selector de control de mi menu
        int opc = 0;
        long numero = 0;
        // Desplegar el menu
        do
        {
            Console.Clear();
            Console.WriteLine("RECURSIVIDAD");
            Console.WriteLine("-----------------------");
            Console.WriteLine("0. INGRESE NUMERO");
            Console.WriteLine("1. FACTORIAL");
            Console.WriteLine("2. FIBONNACI");
            Console.WriteLine("3. SALIR");
            Console.WriteLine("-----------------------");
            Console.WriteLine("INGRESE OPCION: ");
            opc= Convert.ToInt32(Console.ReadLine());

            //materializar el menu por medio de la estructura de control switch case
            switch (opc)
            {
                case 0:
                    Console.WriteLine("Ingrese un numero para calculo: ");
                    numero=Convert.ToInt64(Console.ReadLine());
                    break;
                case 1:
                    Console.WriteLine("Factorial de [" + numero + "]: " + Factorial(numero));
                    break;
                case 2:
                    Console.WriteLine("Fibonacci de [" + numero + "]: " + Fibonacci(numero));
                    break;
                case 3:
                    Console.WriteLine("Adios, gracias por usar el programa");
                    break;
                default:
                    Console.WriteLine("Opps algo salio mal, ingrese una opcion de nuevo");
                    break;
            }
            Console.ReadKey();
        } while (opc!=3);
    }
    //methods
    public static long Fibonacci(long numero)
    {
            if (numero <= 1)
            {
                return numero;
            }
            else
            {
                return Fibonacci(numero - 1) + Fibonacci(numero - 2);
            }
    }
    public static long Factorial(long numero)
    {
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(numero - 1) * numero;
            }
    }
}