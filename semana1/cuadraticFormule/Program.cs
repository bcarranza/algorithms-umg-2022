// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Figgle;
internal class Program
{

    private static void Main(string[] args)
    {
        double x_positivo = 0;
        double x_negativo = 0;
        double a = 0;
        double b = 0;
        double c = 0;

        Console.WriteLine(FiggleFonts.Ogre.Render("FORMULA CUADRATICA"));
        Console.Write("Ingrese a: ");
        a = Convert.ToDouble(Console.ReadLine());
        if(a==0)
        {
            Console.WriteLine("No es posible operar divisiones a 0");
            return;
        }
        Console.Write("Ingrese b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese c: ");
        c = Convert.ToDouble(Console.ReadLine());
        
        //proceso

        x_positivo = ((b*-1) + Math.Sqrt(Math.Pow(b,2) - (4*a*c)))/(2*a);
        x_negativo = ((b*-1) - Math.Sqrt(Math.Pow(b,2) - (4*a*c)))/(2*a);
        
        Console.WriteLine(FiggleFonts.Ogre.Render("RESULTADOS"));
        
        Console.WriteLine("a + = " + a);
        Console.WriteLine("b - = " + b);
        Console.WriteLine("c - = " + c);

        Console.WriteLine("x + = " + x_positivo);
        Console.WriteLine("x - = " + x_negativo);

    }
}



