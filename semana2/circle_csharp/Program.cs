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
        if(radio<0){
            Console.WriteLine("No es posible calcular el permitro y superficie ya que el circulo tiene un radio imaginario");    
        }
        if(radio==0){
            Console.WriteLine("No es posible calcular el permitro y superficie ya que parece ser que esto no correspondo a un circulo si no que a un solo punto");    
        }
        superficie =  Math.Pow(pi * radio,2);
        perimetro = 2 * pi * radio;
        Console.WriteLine("La superficie es: " + superficie);
        Console.WriteLine("El perímetro es " + perimetro);
    }
}



