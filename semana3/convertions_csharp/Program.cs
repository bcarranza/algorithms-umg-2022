//El siguiente programa no tiene un orden en especifico
//solo trata de demostrar sintaxis para ciertas conversiones
//y operaciones matematicas.

using System.Globalization;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
       //Variable types
        string cliente;
        int edad;
        bool valido;
        double monto;
        
        //Asignando valores
        cliente = "Jose Ramirez";
        edad = 20;
        valido = true;
        monto=2040.30;

        //Imprimiendo    
        Console.WriteLine("Cliente: " + cliente);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Valido: " + valido);
        Console.WriteLine("Monto: " + monto);
        
        //Leeamos un valor de la consola (generando errores)
        /*Console.WriteLine("Ingrese el cliente: ");
        cliente=Console.ReadLine();

        Console.WriteLine("Ingrese la edad: ");
        edad=Console.ReadLine();

        Console.WriteLine("Es un cliente valido?: ");
        valido=Console.ReadLine();
        
        Console.WriteLine("Ingrese el salario del cliente: ");
        monto=Console.ReadLine();*/

        //Leeamos un valor de la consola (forma correcta)
        Console.WriteLine("Ingrese el cliente: ");
        cliente=Console.ReadLine();

        Console.WriteLine("Ingrese la edad: ");
        edad= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Es un cliente valido?: ");
        valido= Convert.ToBoolean(Console.ReadLine());
        
        Console.WriteLine("Ingrese el salario del cliente: ");
        monto= Convert.ToDouble(Console.ReadLine());

        //Imprimiendo de nuevo 
        Console.WriteLine("Cliente: " + cliente);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Valido: " + valido);
        Console.WriteLine("Monto: " + monto);

        // Expresiones matematicas
        //Potencia
        double a= Math.Pow(5,2);
        //Raiz cuadrada
        double b = Math.Sqrt(4);
        // Valor absoluto
        double c = Math.Abs(-4);
        // Numero al azar
        Random rnd = new Random();
        int e = rnd.Next();

        Console.WriteLine("Potencia: " + a);
        Console.WriteLine("Raiz cuadrada: " + b);
        Console.WriteLine("Valor absoluto: " + c);
        Console.WriteLine("Azar: " + e);
        

        //Mod y Div
        //

    }
}