using System;
					
public class Program
{
	public static void Main()
	{
        int opc=0;
        int[] list = new int[10];
		int[] list2 = new int[10];  
          
        //Menu por medio de una estructura repetitiva do while
        
		do {
                Console.Clear();
                Console.WriteLine("Menu Principal"); 
				Console.WriteLine(" ");
				Console.WriteLine("1. Ingresar Valores");
                Console.WriteLine("2. Generar el nuevo vector");         
				Console.WriteLine("3. Imprimir el Vector #1");
				Console.WriteLine("4. Imprimir el Vector #2");      
				Console.WriteLine("5. Salir");
				Console.WriteLine(" ");
				Console.WriteLine("Ingresar Opción que desea realizar");
				opc = Convert.ToInt32(Console.ReadLine());
                
                switch (opc) 
				{
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
                        Console.WriteLine("Generando Vector # 2");
                        int newIndex = 0;
                        for (int i = list.Length-1; i>=0; i--)  //9,8,7,6,5,4,3,2,1,0
                        {
                            //opcion 1
                            list2[newIndex] = list[i];
                            newIndex++;
                            

                            //opcion 2
                            //list2[(list.Length-1)-i] = list[i];
                            
                            
                            
                            //tabla de corrida
                            //vuelta 1: list2[9-9=0] = list[9] 
                            //vuelta 2: list2[9-8=1] = list[8]
                            //..
                            //..
                            //ultima vuelta list2[9-0=9] = list[0];

                        }
                        break; 
                    case 3:
                        Console.WriteLine("Imprimiendo valores del arreglo 1");
                        for (int i = 0; i < list.Length; i++)
                        {
                            Console.WriteLine("Posición [" + i + "]: " + list[i]);    
                        }
                        break;
                    case 4:
                        Console.WriteLine("Imprimiendo valores del arreglo 2");
                        for (int i = 0; i < list2.Length; i++)
                        {
                            Console.WriteLine("Posición [" + i + "]: " + list2[i]);    
                        }
                        break;
                    case 5:
                        Console.WriteLine("Adios, gracias por usar el programa");
                        break;
                    default:
                        Console.WriteLine("Opps algo salio mal, ingrese una opcion de nuevo");
                        break;
			    }
				Console.ReadKey();	
		} while (opc !=5);
    }
}

/*
Ejercicio 1Permalink
Crear un vector de 5 elementos de cadenas de caracteres, 
inicializa el vector con datos leídos por el teclado. 
Copia los elementos del vector en otro vector pero en orden inverso, 
y muéstralo por la pantalla.
*/









