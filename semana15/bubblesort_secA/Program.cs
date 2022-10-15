using System;
public class Program
{
    public static void Main()
    {
        int[] array= new int[5];
        array[0] = 5;
        array[1] = 2;
        array[2] = 4;
        array[3] = 1;
        array[4] = 3;
        
        //Impresión arreglo desordenado
        Console.WriteLine("Imprimiendo arreglo desordenado");
        Console.WriteLine("-------------------------------");
        for (int x = 0; x < array.Length; x++)
        {
            Console.WriteLine(array[x]);
        }
        //Aplicando metodo burbuja
        Console.WriteLine("Aplicando metodo burbuja");
        Console.WriteLine("-------------------------------");
        for (int x = 0; x < array.Length; x++)
        {
            // Recuerda que el -1 es porque no queremos llegar al final ya que hacemos
            // un indiceActual + 1 y si fuéramos hasta el final, intentaríamos acceder a un valor fuera de los límites
            // del arreglo
            for (int indiceActual = 0; indiceActual < array.Length - 1; indiceActual++)
            {
                int indiceSiguienteElemento = indiceActual + 1;
                
                // Si el actual es mayor que el que le sigue a la derecha...
                if (array[indiceActual] > array[indiceSiguienteElemento])
                {
                    Console.WriteLine("Swapping");
                    int temporal = array[indiceActual];
                    array[indiceActual] = array[indiceSiguienteElemento];
                    array[indiceSiguienteElemento] = temporal;
                }
                else
                {
                    Console.WriteLine("No swap");
                }
                Console.WriteLine(array[indiceActual] + ">" + array[indiceSiguienteElemento]);
            }
        }

        Console.WriteLine("-------------------------------");
        //Impresión de arreglo
        Console.WriteLine("Imprimiendo arreglo ordenado");
        Console.WriteLine("-------------------------------");
        for (int x = 0; x < array.Length; x++)
        {
            Console.WriteLine(array[x]);
        }
    }
}