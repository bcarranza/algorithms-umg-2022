//El siguiente programa no tiene un orden en especifico
//solo trata de demostrar sintaxis para ciertas conversiones
//y operaciones matematicas.

/*
Enunciado: Enunciado: Dada la matrícula y 5 calificaciones de un alumno 
obtenidas a lo largo del semestre, construya un diagrama de flujo que 
imprima la matrícula del alumno y el promedio de sus calificaciones. 
Si su promedio es menor a 60 imprima No promovido de lo contrario imprimir 
Promovido la materia. Imprima una ficha(sea creativo).

*/


using System.Globalization;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //declaración de variables
        string matricula;
        string nombreEstudiante;

        int nota1;
        int nota2;
        int nota3;
        int nota4;
        int nota5;

        double prom;
        bool promovido;

        Console.WriteLine("Ingrese Matricula del estudiante: ");
        matricula = Console.ReadLine();

        Console.WriteLine("Ingrese el nombre del estudiante: ");
        nombreEstudiante = Console.ReadLine();

        Console.WriteLine("Ingrese nota 1: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese nota 2: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese nota 3: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese nota 4: ");
        nota4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese nota 5: ");
        nota5 = Convert.ToInt32(Console.ReadLine());

        if(nota1 <=0 || nota2<=0 || nota3<=0 || nota4<=0 || nota5<=0){
            Console.WriteLine("Algo falló: Notas menores a 0 no permitidas");        
            return; 
        }
        else{
            prom = (nota1+nota2+nota3+nota4+nota5)/5;
            if (prom < 60)
            {
                promovido = false;
            }
            else
            {
                promovido = true;
            }
            //Imprimiendo ficha
            Console.WriteLine("Calculando datos del alumno.......");
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Nombre: " + nombreEstudiante);
            Console.WriteLine("Notas.............................");
            Console.WriteLine("Nota 1: " + nota1);
            Console.WriteLine("Nota 2: " + nota2);
            Console.WriteLine("Nota 3: " + nota3);
            Console.WriteLine("Nota 4: " + nota4);
            Console.WriteLine("Nota 5: " + nota5);
            Console.WriteLine("Promedio: " + prom);
            Console.WriteLine("Resultado: " + ((promovido==true) ? "Promovido" : "No promovido"));

        }
    }
}