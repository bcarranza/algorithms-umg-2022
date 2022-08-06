/*
Autor: Bayron Carranza
Github: bayron.carranza
Descripción: Ingrese el peso en libras y la longitud en metros de un 
dinosaurio y calcule el peso en kilos y la longitud en metros.
*/

using System;
internal class Program
{   
    private static void Main(string[] args)
    {
      //code here
        string nombre;
        double libras;
		double pies;

        //Entrada
		Console.WriteLine("Escribir el nombre del Dinosaurio: ");
		nombre = Console.ReadLine();		
		
        Console.WriteLine("Ingrese el peso del Dinosaurio, " + nombre + " en libras: ");
		libras = double.Parse(Console.ReadLine()); //Alt 50 (2) -> 2.00 vs (2)
       
        Console.WriteLine("Ingrese longitud del Dinosaurio, " + nombre + " en pies: ");
		pies = double.Parse(Console.ReadLine());						  
		
        //Proceso
		double kilogramos = libras * 0.453592;
		double metros =	pies * 0.3048;
		
        //Salida
		Console.WriteLine("------------------------");
        Console.WriteLine("Soy: " + nombre);
		Console.WriteLine("Mi peso en kilogramos es: " + kilogramos.ToString("0.00"));
		Console.WriteLine("Mi longitud en metros es: " + metros.ToString("0.00"));      
    }
}

