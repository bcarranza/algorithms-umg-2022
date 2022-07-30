/*
Enunciado:
Dada la matrícula y 5 calificaciones de un alumno obtenidas a lo largo 
del semestre, construya un diagrama de flujo que imprima la matrícula 
del alumno y el promedio de sus calificaciones. Si su promedio es menor 
a 60 imprima No promovido de lo contrario imprimir Promovido. 
Imprima una ficha(sea creativo).
*/

using System.Globalization;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //sección de declaración de variables
        string matricula;
        string nombreAlumno;
        string materia;
        string ciclo;
        
        // variables de notas
        int nota1;
        int nota2;
        int nota3;
        int nota4;
        int nota5;

        double promedio;
        bool promovido;
        string firma;
        bool transaccionConfirmada;

        Console.WriteLine("Bienvenidos al sistema de notas XYZ");
        
        Console.WriteLine("Ingrese la matricula: ");
        matricula = Console.ReadLine();

        Console.WriteLine("Ingrese el nombre del alumno: ");
        nombreAlumno = Console.ReadLine();    

        Console.WriteLine("Ingrese la materia: ");
        materia = Console.ReadLine();    

        Console.WriteLine("Ingrese el ciclo: ");
        ciclo = Console.ReadLine();   

        Console.WriteLine("Ingrese la nota 1: ");
        nota1 =  Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Ingrese la nota 2: ");
        nota2 =  Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Ingrese la nota 3: ");
        nota3 =  Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Ingrese la nota 4: ");
        nota4 =  Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Ingrese la nota 5: ");
        nota5 =  Convert.ToInt32(Console.ReadLine()); 

        //determinar si las notas son validas
        if (nota1 < 0 || nota2 < 0 || nota3 < 0 || nota4 < 0 || nota5 < 0)
        {
            Console.WriteLine("Ohh Algo ha fallado: Al menos una de las notas fue ingresada como 0");
            return;
        }
        else
        {
            promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            /* otra opción con menos lineas. 
            if(promedio >= 60)
            {
                promovido = true
            }
            */
            if (promedio<60)
            {
                promovido = false;
            }else
            {
                promovido = true;
            }

            //firma
            Console.WriteLine("Ingrese su iniciales: ");
            firma =  Console.ReadLine(); 

            Console.WriteLine("Ingrese y/n para confirmar o denegar la transacción");
            
            if(Console.ReadLine()=="y"){
                transaccionConfirmada=true;
            }else
            {
                transaccionConfirmada=false;
            }

            if (transaccionConfirmada)
            {
                //imprimir ficha   
                Console.WriteLine("Datos de Estudiante...........................");
                Console.WriteLine("Nombre: " + nombreAlumno);
                Console.WriteLine("Materia: " + materia);
                Console.WriteLine("Ciclo: " + ciclo);
                Console.WriteLine("Notas.........................................");
                Console.WriteLine("Nota1: " + nota1);
                Console.WriteLine("Nota2: " + nota2);
                Console.WriteLine("Nota3: " + nota3);
                Console.WriteLine("Nota4: " + nota4);
                Console.WriteLine("Nota5: " + nota5);
                Console.WriteLine("Resultados....................................");
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("Resultado: " + ((promovido) ? "Promovido" : "No Promovido"  ) );
                Console.WriteLine("Catedratico: " + firma);
                Console.WriteLine("Fin...........................................");

            }
            else{
                Console.WriteLine("Transacción Cancelada");
                return;
            }
        }
    }
}