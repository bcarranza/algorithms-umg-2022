using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        double radio = 0;
        double superficie = 0;
        double perimetro = 0;
        const double pi = 3.1416;

        Console.WriteLine("Introduce el radio de la circunferencia:");
        radio = Convert.ToDouble(Console.ReadLine());
        superficie =  Math.Pow(pi * radio,2);
        perimetro = 2 * pi * radio;
        Console.WriteLine("La superficie es: " + superficie);
        Console.WriteLine("El perímetro es " + perimetro);
    }
}



