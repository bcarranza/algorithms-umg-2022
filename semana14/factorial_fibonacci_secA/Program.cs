using System;
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
                    Console.WriteLine("Factorial de [" + numero + "]: " + Fact(numero));
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
    public static long Fact(long n)
    {
            if (n == 0 || n==1)
            {
                return 1;
            }
            else
            {
                return n * Fact(n - 1);
            }

            //ingresa a funcion Factorial (10)
            //i1: 10 != 0 por lo tanto llama a Factorial(10-1)*10
            //i2:  9 != 0 por lo tanto llama a Factorial(9-1)*9
            //i3:  8 != 0 por lo tanto llama a Factorial(8-1)*8
            //i4:  7 != 0 por lo tanto llama a Factorial(7-1)*7
            //i5:  6 != 0 por lo tanto llama a Factorial(6-1)*6
            //i6:  5 != 0 por lo tanto llama a Factorial(5-1)*5
            //i7:  4 != 0 por lo tanto llama a Factorial(4-1)*4
            //i8:  3 != 0 por lo tanto llama a Factorial(3-1)*3
            //i9:  2 != 0 por lo tanto llama a Factorial(2-1)*2
           //i10:  1 != 0 por lo tanto llama a Factorial(1-1)*1
           //i11:  0 == 0 por lo tanto retorna 1 (break)
    }
}