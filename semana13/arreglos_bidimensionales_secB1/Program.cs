using System; 
public class Program
{
    public static void Main(){
        // opc es el selector de nuestro menu
        int opc = 0;

        // Variables encargadas de la dimension de nuestra matriz n*m filas*columnas
        int filas=10; // filas 
        int columnas=10; // columnas
        
        // Instanciar matrices de 10*10 vacia
        int[,] MatrizA = new int[filas,columnas];
        int[,] MatrizB = new int[filas,columnas];
        
        // Desplegar el menu principal
        do
        {
            Console.Clear();
            Console.WriteLine("OPERACIONES DE MATRICES");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Rellenar Matrices Aleatoriamente");
            Console.WriteLine("2. Suma de Matrices");
            Console.WriteLine("3. Número Mayor de ambas matrices");
            Console.WriteLine("4. Imprimir matrices");
            Console.WriteLine("5. Imprimir la diagonal principal de ambas matrices");
            Console.WriteLine("6. Imprimir la diagonal principal de ambas matrices");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Ingresar opción: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    FillMatrix(MatrizA, MatrizB);
                    break;
                case 2:
                    SumMatrix(MatrizA, MatrizB);
                    break;
                case 3:
                    //llamado de funcion
                    Console.WriteLine("El mayor es: " + GetMaxNumber(MatrizA, MatrizB));
                    break;
                case 4:
                    PrintMatrix(MatrizA, MatrizB);    
                    break;
                case 5:
                    DiagonalMatrix(MatrizA, MatrizB);    
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
    public static void FillMatrix(int[,] MatrizA, int[,] MatrizB)
    {
        int filas = MatrizA.GetLength(0);
        int columnas = MatrizA.GetLength(0);

        Random rnd = new Random();
        // forma # 1 , tengo variables donde almacené cuantas filas y cuantas columnas quiero
        for (int i = 0; i < filas; i++) //filas
        {
            for (int j = 0; j < columnas; j++) // columnas
            {
                MatrizA[i,j] = rnd.Next(0,100);
                MatrizB[i,j] = rnd.Next(0,100);
            }
        } 
        Console.WriteLine("Matrices rellenadas correctamente");
        /*
        // forma # 2, le pregunto a la matriz cual es su tamaño
        for (int i = 0; i < MatrizA.GetLength(0); i++) //filas
        {
            for (int j = 0; j < MatrizA.GetLength(1); j++) //columnas
            {
                MatrizA[i,j] = 0;
                MatrizB[i,j] = 0;
            }
        }
        */
    }
    //metodo
    public static void SumMatrix(int[,] MatrizA, int[,] MatrizB)
    {   
        int filas = MatrizA.GetLength(0);
        int columnas = MatrizA.GetLength(0);
        int sumaCeldas = 0;

        Console.WriteLine("RESULTADO DE SUMA DE MATRICES");
        for (int i = 0; i < filas; i++) //filas
        {
            for (int j = 0; j < columnas; j++) // columnas
            {
                sumaCeldas = MatrizA[i,j] + MatrizB[i,j];
                Console.Write(sumaCeldas + "\t");
            }
            Console.WriteLine("");
        } 
    }
    //funcion
    public static int GetMaxNumber(int[,] MatrizA, int[,] MatrizB)
    {
         int buffer = 0;
         int filas = MatrizA.GetLength(0);
         int columnas = MatrizA.GetLength(0);

        //generando nueva matriz
        for (int i = 0; i < MatrizA.GetLength(0); i++)
        {
            for (int j = 0; j < MatrizA.GetLength(1); j++)
            {
                if(buffer<MatrizA[i,j])
                    buffer =  MatrizA[i,j];

                if(buffer<MatrizB[i,j])
                    buffer =  MatrizB[i,j];
            }
        }
        return buffer;
    }

    //metodo
    public static void PrintMatrix(int[,] MatrizA, int[,] MatrizB)
    {
        //imprimiendo matrix a
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX A---------------");
        Console.WriteLine("");
        for (int i = 0; i < MatrizA.GetLength(0); i++) // filas 
        {
            for (int j = 0; j < MatrizA.GetLength(1); j++) // columnas
            {
                Console.Write(MatrizA[i,j] + "\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX B---------------");
        Console.WriteLine("");
        //imprimiendo matrix b
        for (int i = 0; i < MatrizB.GetLength(0); i++)
        {
            for (int j = 0; j < MatrizB.GetLength(1); j++)
            {
                Console.Write(MatrizB[i,j] + "\t");
            }
            Console.WriteLine("");
        }
    }
    //metodo
    public static void DiagonalMatrix(int[,] MatrizA, int[,] MatrizB)
    {
        //imprimiendo matrix a
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX A---------------");
        Console.WriteLine("");
        for (int i = 0; i < MatrizA.GetLength(0); i++)
        {
            for (int j = 0; j < MatrizA.GetLength(1); j++)
            {
                if(i==j)
                    Console.Write(MatrizA[i,j] + "\t");
                else
                    Console.Write(0 + "\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine("--------MATRIX B---------------");
        Console.WriteLine("");
        //imprimiendo matrix b
        for (int i = 0; i < MatrizB.GetLength(0); i++)
        {
            for (int j = 0; j < MatrizB.GetLength(1); j++)
            {
                if(i==j)
                    Console.Write(MatrizB[i,j] + "\t");
                else
                    Console.Write(0 + "\t");
            }
            Console.WriteLine("");
        }
    }
}

