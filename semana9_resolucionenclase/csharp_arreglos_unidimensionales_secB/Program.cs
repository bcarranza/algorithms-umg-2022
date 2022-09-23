using System;
					
public class Program
{
	public static void Main()
	{
        int opc;
        int buffer;
        int[] list = null; //feature 1
        int arraySize = 0; //feature 1
        int pares = 0; //feature 2
        int impares = 0;  //feature 2
        string bufferStr = ""; //feature 3
        int[] listSquare = null; //feature 3
        opc=0;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU DE ARREGLOS UNIDIMENSIONALES");
            Console.WriteLine("0. Definir tamaño del arreglo");  //feature 1
            Console.WriteLine("1. Ingresar valores al arreglo");
            Console.WriteLine("2. Imprimir valores del arreglo");
            Console.WriteLine("3. Imprimir el valor mas alto del arreglo");
            Console.WriteLine("4. Imprimir el valor mas bajo del arreglo");
            Console.WriteLine("5. Imprimir la suma total del arreglo");
            Console.WriteLine("6. Imprimir el arreglo al reves");
            Console.WriteLine("7. Imprimir el resumen de números pares y números impares"); //feature 2
            Console.WriteLine("8. Imprimir el arreglo elevado al cuadrado (cada elemento)");
            Console.WriteLine("9. Imprimir los números primos");
            Console.WriteLine("10. Salir");

            Console.WriteLine("Ingresar opcion del menu: ");
            opc = Convert.ToInt32(Console.ReadLine());  //convirtiendo de cadena a numero

            switch (opc)
            {
                case 0: //feature 1
                    Console.WriteLine("Ingrese el tamaño deseado del arreglo: ");
                    arraySize = Convert.ToInt32(Console.ReadLine());
                    list = new int[arraySize]; 
                    break;
                case 1:
                    Console.WriteLine("Ingresando valores al arreglo");
                    for (int i = 0; i < list.Length; i++)
                    {
                        Console.WriteLine("Ingrese un numero para la posición " + i);
                        list[i]=Convert.ToInt32(Console.ReadLine());     
                    }
                    Console.WriteLine("Proceso finalizado...");
                    break;
                case 2:
                    Console.WriteLine("Imprimiendo valores del arreglo");
                    for (int i = 0; i < list.Length; i++)
                    {
                        Console.WriteLine("Posición [" + i + "]: " + list[i]);    
                    }
                    break;
                case 3:
                    Console.WriteLine("Imprimiendo el valor mas alto del arreglo");
                    buffer=0;
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (list[i]>buffer)
                        {
                            buffer=list[i];
                        }
                    }
                    Console.WriteLine("El numero mayor es: " + buffer);
                    break;
                case 4:
                    Console.WriteLine("Imprimiendo el valor mas bajo del arreglo");
                    buffer=0;
                    for (int i = 0; i < list.Length; i++)
                    {   
                        if (i==0)
                        {
                            buffer=list[i];
                        }
                        else
                        {
                            if (list[i]<buffer)
                            {
                                buffer=list[i];
                            }    
                        }
                    }
                    Console.WriteLine("El numero menor es: " + buffer);
                    break;
                case 5:
                    Console.WriteLine("Imprimiendo la suma total del arreglo");
                    buffer=0;
                    for (int i = 0; i < list.Length; i++)
                    {
                        buffer=buffer+list[i];   
                    }
                    Console.WriteLine("La suma del arreglo es: " + buffer);
                    break;
                case 6:
                    Console.WriteLine("Imprimiendo el arreglo al reves");
                    for (int i = list.Length-1; i>=0; i--)
                    {
                        Console.WriteLine("Posicion [" + i +"]:" + list[i]);
                    }
                    break;
                
                case 7: //feature 2
                    pares = 0;
                    impares = 0;
                    Console.WriteLine("Resumen: Pares e impares");
                    for (int i = 0; i < list.Length; i++)
                    {
                        if ((list[i] % 2) == 0) //dividimos el numero entre 2 y si la division es exacta lo determina como par de lo contrario es impar.
                        {
                            pares++; 
                        }
                        else
                        {
                            impares++;
                        }
                    }
                    Console.WriteLine("Resultado.........");
                    Console.WriteLine("Pares: " + pares );
                    Console.WriteLine("Impares: " + impares );
                    break;
                case 8:
                    bufferStr = "";
                    listSquare = null;
    
                    Console.WriteLine("Desea crear un nuevo arreglo?");
                    if (Console.ReadKey() == "si")
                    {
                        Console.WriteLine("El arreglo al cuadrado");
                        //arreglo
                        listSquare = new int[list.Length];
                        
                        //llenando el arreglo de cuadrados.
                        for (int i = 0; i < list.Length; i++)
                        {
                            listSquare[i] = Math.Pow(list[i],2);
                        }
                        // imprimirlo
                        for (int i = 0; i < list.Length; i++)
                        {
                            Console.WriteLine("Posición [" + i + "]: " + list[i] + " al cuadrado: " + listSquare[i]);    
                        }

                        //alternativa a la impresion del arreglo. (imprimir separado por comas en una sola linea basado en mi arreglo listSquare) Join
                        //Console.WriteLine(string.Join("," listSquare));


                    }else
                    {
                        Console.WriteLine("El arreglo al cuadrado");
                        //cadena
                        for (int i = 0; i < list.Length; i++)
                        {
                            bufferStr =  ((i == list.Length-1) ? (bufferStr + Math.Pow(list[i],2).ToString())  : (bufferStr + Math.Pow(list[i],2).ToString() + ", "));
                            //bufferStr + Math.Pow(list[i],2).ToString() + ", ";           //if implicito
                            //if implicito :      (condition) ? (true) : (false)
                            //1  2  3  4
                            //1, 4, 9, 16
                        }
                        Console.WriteLine("Resultado: " + bufferstr);
                    }

                    break;
                case 8: //feature 4
                    bufferstr=""; 
                    Console.WriteLine("Resumen de los numeros primos");
                    for (int i = 0; i < list.Length; i++)
                    {
                        if(EsPrimo(list[i]))
                        {
                            bufferstr = ((i==list.Length-1) ? (bufferstr + list[i].ToString()) : (bufferstr + list[i] + ",")); 
                        }
                    }
                    Console.WriteLine("Resultado: " + bufferstr);
                    break;
                default:
                    Console.WriteLine("Opps algo salio mal, ingrese una opcion de nuevo");
                    break;
            }
            Console.ReadKey();
        } while (opc!=10);
    }
    static bool EsPrimo(int numero)
    {
            for (int i = 2; i < numero; i++)
            {
                if((numero % i) == 0)
                {
                    // No es primo 🙁
                    return false;
                }
            }
            // Es primo 🙂
            return true;
    }
}