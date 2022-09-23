using System;
					
public class Program
{
    
	public static void Main()
	{
        int opc=0;
        int m=10;
        int n=10;
        int[,] matrizA = new int[m,n];
		int[,] matrizB = new int[m,n];            
        //Menu por medio de una estructura repetitiva do while
        
		do {
                Console.Clear();
                Console.WriteLine("OPERACIONES DE MATRICES"); 
				Console.WriteLine(" ");
				Console.WriteLine("1. Rellenar Matrices");
                Console.WriteLine("2. Suma de matrices");         
				Console.WriteLine("3. Numero Mayor");
				Console.WriteLine("4. Impresion de Matrices");   
                Console.WriteLine("5. Impresion de Diagonal Principal");   
				Console.WriteLine("6. Salir");
				Console.WriteLine(" ");
				Console.WriteLine("Ingresar Opción que desea realizar");
				opc = Convert.ToInt32(Console.ReadLine());
                
                switch (opc) 
				{
                    case 1: 
                        FillMatrix(matrizA, matrizB);
                        break;  
                    case 2:
                        SumMatrix(matrizA, matrizB);
                        break; 
                    case 3:
                        Console.WriteLine("el numero mayor es: " + GetMaxNumber(matrizA, matrizB));
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
		} while (opc !=6);
    }
    public static void FillMatrix(int[,] matrizA, int[,] matrizB){
        Random rnd = new Random();
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizA[i,j]=rnd.Next(0,100);
                matrizB[i,j]=rnd.Next(0,100);
            }
        }
    }
    public static void SumMatrix(int[,] matrizA, int[,] matrizB){
        int buffer = 0;
        //generando nueva matriz
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                buffer = matrizA[i,j] + matrizB[i,j];
                Console.Write(buffer + "\t");
            }
            Console.WriteLine("");
        }
    }
    public static int GetMaxNumber(int[,] matrizA, int[,] matrizB){
        int buffer = 0;
        //generando nueva matriz
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                if(buffer<matrizA[i,j])
                    buffer =  matrizA[i,j];

                if(buffer<matrizB[i,j])
                    buffer =  matrizB[i,j];
            }
        }
        return buffer;
    }
    
     public static void PrintMatrix(int[,] matrizA, int[,] matrizB){
        //imprimiendo matrix a
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX A---------------");
        Console.WriteLine("");
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                Console.Write(matrizA[i,j] + "\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX B---------------");
        Console.WriteLine("");
        //imprimiendo matrix b
        for (int i = 0; i < matrizB.GetLength(0); i++)
        {
            for (int j = 0; j < matrizB.GetLength(1); j++)
            {
                Console.Write(matrizB[i,j] + "\t");
            }
            Console.WriteLine("");
        }
    }

    public static void DiagonalMatrix(int[,] matrizA, int[,] matrizB){
        //imprimiendo matrix a
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX A---------------");
        Console.WriteLine("");
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
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
        for (int i = 0; i < matrizB.GetLength(0); i++)
        {
            for (int j = 0; j < matrizB.GetLength(1); j++)
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