using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        // Selector de control de mi menu
        int opc = 0;
        long n = 0;
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
                    n=Convert.ToInt64(Console.ReadLine());
                    break;
                case 1:
                    Console.WriteLine("Factorial de [" + n + "]: " + Factorial(n));
                    break;
                case 2:
                    Console.WriteLine("Fibonacci de [" + n + "]: " + Fibonacci(n));
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
    public static long Fibonacci(long n)
    {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
    }
    public static long Factorial(long n)
    {
            if (n == 0 || n == 1)
            {
                Console.WriteLine("(break) Caso Base: factorial de " + n + " es igual a =" + n);
                return 1;
            }
            else
            {
                Console.WriteLine("iteracion n: " + n + " n-1: " + (n-1));
                return Factorial(n - 1) * n;
                
   
            }

            //tabla de recorrido
            //i1 = n = 10 -> factorial(10-1)*10
            //i2 = n = 9  -> factorial( 9-1)*9
            //i3 = n = 8  -> factorial( 8-1)*8
            //...
            //i9 = n = 2  -> factorial( 2-1)*2
           //i10 = n = 1  -> factorial(1-1)*1
           //i11 = n = 0  -> break(rompe criterio porque n==0 es 1);   
    }
}