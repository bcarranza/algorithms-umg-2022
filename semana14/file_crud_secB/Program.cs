//docs: https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/file-io-operation

using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        // Selector de control de mi menu
        int opc = 0;
        StreamWriter writer = null;
        // Desplegar el menu
        do
        {
            Console.Clear();
            Console.WriteLine("OPERACIONES DE MATRICES");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. CREAR ARCHIVO");
            Console.WriteLine("2. ESCRIBIR");
            Console.WriteLine("3. LEER");
            Console.WriteLine("4. BORRAR");
            Console.WriteLine("5. SALIR");
            Console.WriteLine("-----------------------");
            Console.WriteLine("INGRESE OPCION: ");
            opc= Convert.ToInt32(Console.ReadLine());

            //materializar el menu por medio de la estructura de control switch case
            switch (opc)
            {
                case 1:
                    CreateFile(writer);
                    break;
                case 2:
                    WriteFile(writer);
                    break;
                case 3:
                    ReadFile(writer);
                    break;
                case 4:
                    DeleteFile(writer);
                    break;
                case 5:
                    Console.WriteLine("Adios, gracias por usar el programa");
                    break;
                default:
                    Console.WriteLine("Opps algo salio mal, ingrese una opcion de nuevo");
                    break;
            }
            Console.ReadKey();
        } while (opc!=5);
    }
    //methods
    public static void CreateFile(StreamWriter writer){
        writer = new StreamWriter("./myfile.txt");
        writer.Close();
        Console.WriteLine("File was created suscessfully");
    }
    public static void WriteFile(StreamWriter writer){
        writer = new StreamWriter("./myfile.txt");
        writer.WriteLine(@"
                        ───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
            ─██████──██████─██████████████─██████─────────██████████████────██████──────────██████─██████──██████─██████──────────██████─████████████───██████████████─
            ─██░░██──██░░██─██░░░░░░░░░░██─██░░██─────────██░░░░░░░░░░██────██░░██████████████░░██─██░░██──██░░██─██░░██████████──██░░██─██░░░░░░░░████─██░░░░░░░░░░██─
            ─██░░██──██░░██─██░░██████░░██─██░░██─────────██░░██████░░██────██░░░░░░░░░░░░░░░░░░██─██░░██──██░░██─██░░░░░░░░░░██──██░░██─██░░████░░░░██─██░░██████░░██─
            ─██░░██──██░░██─██░░██──██░░██─██░░██─────────██░░██──██░░██────██░░██████░░██████░░██─██░░██──██░░██─██░░██████░░██──██░░██─██░░██──██░░██─██░░██──██░░██─
            ─██░░██████░░██─██░░██──██░░██─██░░██─────────██░░██████░░██────██░░██──██░░██──██░░██─██░░██──██░░██─██░░██──██░░██──██░░██─██░░██──██░░██─██░░██──██░░██─
            ─██░░░░░░░░░░██─██░░██──██░░██─██░░██─────────██░░░░░░░░░░██────██░░██──██░░██──██░░██─██░░██──██░░██─██░░██──██░░██──██░░██─██░░██──██░░██─██░░██──██░░██─
            ─██░░██████░░██─██░░██──██░░██─██░░██─────────██░░██████░░██────██░░██──██████──██░░██─██░░██──██░░██─██░░██──██░░██──██░░██─██░░██──██░░██─██░░██──██░░██─
            ─██░░██──██░░██─██░░██──██░░██─██░░██─────────██░░██──██░░██────██░░██──────────██░░██─██░░██──██░░██─██░░██──██░░██████░░██─██░░██──██░░██─██░░██──██░░██─
            ─██░░██──██░░██─██░░██████░░██─██░░██████████─██░░██──██░░██────██░░██──────────██░░██─██░░██████░░██─██░░██──██░░░░░░░░░░██─██░░████░░░░██─██░░██████░░██─
            ─██░░██──██░░██─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──██░░██────██░░██──────────██░░██─██░░░░░░░░░░██─██░░██──██████████░░██─██░░░░░░░░████─██░░░░░░░░░░██─
            ─██████──██████─██████████████─██████████████─██████──██████────██████──────────██████─██████████████─██████──────────██████─████████████───██████████████─
            ───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
        ");
        writer.Close();
        Console.WriteLine("File was upgrade suscessfully");
    }
    public static void ReadFile(StreamWriter writer){
       StreamReader reader = new StreamReader("./myfile.txt");
        do
        {
            Console.WriteLine(reader.ReadLine());
        }
        while(reader.Peek()!= -1);
        
    }
    public static void DeleteFile(StreamWriter writer){
        File.Delete("./myfile.txt");
        Console.WriteLine("File was deleted suscessfully");

    }
}