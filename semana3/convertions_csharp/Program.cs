using System.Globalization;
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

    }
}