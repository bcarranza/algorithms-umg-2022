using System;
					
public class Program
{
	public static void Main()
	{
        int opc;
        int buffer;
        string bufferStr="";
        int[] list = null; //feature1
        int[] listSquare = null; //feature3
        int arraySize = 0; //feature1
        int pares = 0;  //feature2
        int impares= 0; //feature2
        opc=0;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU DE ARREGLOS UNIDIMENSIONALES");
            Console.WriteLine("0. Definir el tamaño del arreglo");
            Console.WriteLine("1. Ingresar valores al arreglo");
            Console.WriteLine("2. Imprimir valores del arreglo");
            Console.WriteLine("3. Imprimir el valor mas alto del arreglo");
            Console.WriteLine("4. Imprimir el valor mas bajo del arreglo");
            Console.WriteLine("5. Imprimir la suma total del arreglo");
            Console.WriteLine("6. Imprimir el arreglo al reves");
            Console.WriteLine("7. Imprimir el resumen de números pares y números impares"); //feature2\
            Console.WriteLine("8. Imprimir el arreglo elevado al cuadrado (cada elemento)"); //feature3  (cadenas y arreglos)
            Console.WriteLine("9. Imprimir el arreglo de numeros primos"); //feature3  (cadenas y arreglos)
            Console.WriteLine("10. Salir");

            Console.WriteLine("Ingresar opcion del menu: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 0: //feature1
                    Console.WriteLine("Ingrese el tamaño deseado del arreglo: ");
                    arraySize = Convert.ToInt32(Console.ReadLine());
                    list = new int[arraySize];
                    break;
                case 1:
                    Console.WriteLine("Ingresando valores al arreglo");
                    for (int i = 0; i < list.Length; i++) //0,1,2...7
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
                
                case 7: //feature2
                    pares=0;
                    impares=0;
                    Console.WriteLine("Resumen: Pares e impares");
                    for (int i = 0; i < list.Length; i++)  // 2, 3, 4, 5, 6
                    {
                        if ((list[i] % 2) == 0)
                        {
                            Console.WriteLine("Posicion[" + i + "]: " + list[i] + " es par");
                        }
                        else
                        {
                            Console.WriteLine("Posicion[" + i + "]: " + list[i] + " es impar");
                        }
                    }
                    Console.WriteLine("Resultado.........");
                    Console.WriteLine("Pares: " + pares );
                    Console.WriteLine("Impares: " + impares );
                    break;
                
                case 8: //feature3
                    //opcion 1  arreglo
                        listSquare = null;
                        Console.WriteLine("El arreglo al cuadrado");
                        listSquare = new int[list.Length];
                        
                        //llenar el arreglo nuevo con los cuadrados del arreglo principal
                        for (int i = 0; i < list.Length; i++)
                        {
                            listSquare[i] = Math.Pow(list[i],2); // list[i] * list[i]
                        }

                        //imprimirlo
                        for (int i = 0; i < listSquare.Length; i++)
                        {
                            Console.WriteLine("Posición [" + i + "]: " + listSquare[i]);           
                        }
                        // opcion 1.1 arreglo + cadena  // alternativa a la impresion.
                        Console.WriteLine(string.Join(",",listSquare));


                    //opcion 2  cadena
                        bufferStr = "";  // matematicas para parvulos :   (2,4)   [5,10]
                        //(5) i=0, i=1, i=2, i=3, i=4
                        for (int i = 0; i < list.Length; i++)  //valores: 1,2,3,4,5
                        {
                                           //(condition)     ?          (true)                    :            (false)
                            bufferStr = ((i==list.Length-1)  ?  (bufferStr + Math.Pow(list[i],2)) : bufferStr + Math.Pow(list[i],2) + ", ");
                            //primera vuelta: buffer = "1, "                           
                            //segunda vuelta: buffer = "1, 4, "
                            //tercera vuelta: buffer = "1, 4, 9, "
                            //cuarta vuelta: buffer =  "1, 4, 9, 16, "
                            //quinta vuelta: buffer =  "1, 4, 9, 16, 25"
                        }
                        Console.WriteLine("Resultado: " + bufferStr);  
                    break;
                case 9:
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
                case 10:
                    Console.WriteLine("Adios, gracias por usar el programa");
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