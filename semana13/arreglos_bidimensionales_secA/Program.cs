using System;
public class Program
{
    public static void Main()
    {
        // Selector de control de mi menu
        int opc = 0;
        
        // Definir la dimensión de mis matrices
        int filas=10,columnas=10;

        // Instancias mis matrices
        //int[] arreglo = new int[10] esto era el unidimensional
        int[,] matrizA = new int[filas,columnas];
        int[,] matrizB = new int[filas,columnas];

        // Desplegar el menu
        do
        {
            Console.Clear();
            Console.WriteLine("OPERACIONES DE MATRICES");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. RELLENAR MATRICES ALEATORIAMENTE");
            Console.WriteLine("2. SUMAR MATRICES");
            Console.WriteLine("3. NUMERO MAYOR DE AMBAS MATRICES");
            Console.WriteLine("4. IMPRESION DE MATRICES");
            Console.WriteLine("5. LA DIAGONAL PRINCIPAL DE AMBAS MATRICES");
            Console.WriteLine("6. SALIR");
            Console.WriteLine("-----------------------");
            Console.WriteLine("INGRESE OPCION: ");
            opc= Convert.ToInt32(Console.ReadLine());

            //materializar el menu por medio de la estructura de control switch case
            switch (opc)
            {
                case 1:
                    FillMatrix(matrizA, matrizB);
                    break;
                case 2:
                    SumMatrix(matrizA, matrizB);
                    break;
                case 3:
                    Console.WriteLine("El mayor es: " + GetMaxNumber(matrizA, matrizB));  
                    break;
                case 4:
                    PrintMatrix(matrizA, matrizB);
                    break;
                case 5:
                    DiagonalMatrix(matrizA, matrizB);
                    break;
                case 6:
                    Console.WriteLine("Adios, gracias por usar el programa");
                    break;
                default:
                    Console.WriteLine("Opps algo salio mal, ingrese una opcion de nuevo");
                    break;
            }
            Console.ReadKey();
        } while (opc!=6);
    }
    //method
    public static void FillMatrix(int[,] matrizA, int[,] matrizB){
        int filas = matrizA.GetLength(0); 
        int columnas = matrizA.GetLength(1); 
        
        // llenar aleatoreamente la matriz
        Random rnd = new Random();
        for (int i = 0; i < filas; i++) //filas
        {
            for (int j = 0; j < columnas; j++) //columnas
            {
                matrizA[i,j] = rnd.Next(0,100);
                matrizB[i,j] = rnd.Next(0,100);
            }
        }
        Console.WriteLine("MATRICES GENERADAS CON EXITO");
    } 
    //method
    public static void SumMatrix(int[,] matrizA, int[,] matrizB){
        // MATRIZ A
        // 2    3   4
        // 1    4   2

        // MATRIZ B
        //  3   1   4
        //  4   1   2

        // A + B
        //  5   4   8
        //  5   5   4

        int sumaCeldasEquivalentes = 0;
        int filas = matrizA.GetLength(0); 
        int columnas = matrizA.GetLength(1);
        Console.WriteLine("LA SUMA DE LAS MATRICES ES: ");
        for (int i = 0; i < filas; i++) //filas
        {
            for (int j = 0; j < columnas; j++) //columnas
            {
                sumaCeldasEquivalentes = matrizA[i,j] + matrizB[i,j];
                Console.Write(sumaCeldasEquivalentes + "\t"); //valor + TAB 
            }
            Console.WriteLine(""); //enter
        }

    }
    //funcion
    public static int GetMaxNumber(int[,] matrizA, int[,] matrizB){
        int filas = matrizA.GetLength(0); 
        int columnas = matrizA.GetLength(1);
        int buffer = 0;

        for (int i = 0; i < filas; i++) //filas
        {
            for (int j = 0; j < columnas; j++) //columnas
            {
                // DETERMINANDO EL VALOR MAYOR
                if(buffer<matrizA[i,j])
                    buffer =  matrizA[i,j];

                if(buffer<matrizB[i,j])
                    buffer =  matrizB[i,j];
            }
        }
        return buffer;
    }
    //method
    public static void PrintMatrix(int[,] matrizA, int[,] matrizB){
        int filas = matrizA.GetLength(0); 
        int columnas = matrizA.GetLength(1);

        //imprimiendo matrix a
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX A---------------");
        Console.WriteLine("");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matrizA[i,j] + "\t");
            }
            Console.WriteLine("");
        }
        
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX B---------------");
        Console.WriteLine("");
        //imprimiendo matrix b
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matrizB[i,j] + "\t");
            }
            Console.WriteLine("");
        }

    }
    public static void DiagonalMatrix(int[,] matrizA, int[,] matrizB){
        //  0,0     0,1     0,2     0,3
        //  1,0     1,1     1,2     1,3
        //  2,0     2,1     2,2     2,3
        //  3,0     3,1     3,2     3,3
        int filas = matrizA.GetLength(0); 
        int columnas = matrizA.GetLength(1);


        //imprimiendo matrix a
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX A---------------");
        Console.WriteLine("");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if(i==j)
                    Console.Write(matrizA[i,j] + "\t");
                else
                    Console.Write(0 + "\t");
            }
            Console.WriteLine("");
        }

        Console.WriteLine("");
        Console.WriteLine("--------MATRIX B---------------");
        Console.WriteLine("");
        //imprimiendo matrix b
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if(i==j)
                    Console.Write(matrizB[i,j] + "\t");
                else
                    Console.Write(0 + "\t");
            }
            Console.WriteLine("");
        }


    }
}