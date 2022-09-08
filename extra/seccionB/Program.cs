using System;
public class Program
{
    public static void Main()
    {
        int opc=0;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL........");            
            Console.WriteLine("----------------------");
            Console.WriteLine("1. EJEMPLO DE WHILE...");            
            Console.WriteLine("2. EJEMPLO DE DO-WHILE");
            Console.WriteLine("3. EJEMPLO DE FOR-NEXT");
            Console.WriteLine("4. SALIR..............");

            Console.WriteLine("Ingrese su opción deseada: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc) //selector
            {
                case 1:  //1. EJEMPLO DE WHILE... 
                    Console.WriteLine("Ejectuando: Gastos de viaje");
					Console.WriteLine("Supongamos que debemos obtener una suma de gastos");
					Console.WriteLine("que hicimos en nuestro ultimo viaje, pero no sabemos");
					Console.WriteLine("exactamente cuantos fueron. Los datos son expresados");
					Console.WriteLine("Datos: Gasto1, Gasto2, Gasto3...GastoN, -1");
					Console.ReadKey();

                    double SumGas=0;
                    double Gasto=0;

                    while (Gasto!=-1)
                    {
                        Console.WriteLine("Ingresar nuevo gasto: ");
                        Gasto= Convert.ToDouble(Console.ReadLine());
                        SumGas = SumGas + Gasto;
                        Console.WriteLine("Gasto acumulado: " + SumGas);
                    }
                    break;
                case 2:
                    Console.WriteLine("Mostrando: Ejemplo Do-While");
					Console.WriteLine("Conteo de pares e impares");
					Console.WriteLine("Ingresaremos un numero ");
					Console.WriteLine("al final mostraremos cuantos numeros");
					Console.WriteLine("pares y cuantos impares se ingresaron");
					Console.ReadKey();

                    int n=0,i=1,pares=0,impares=0;

                    Console.WriteLine("Ingrese el tamano de la lista: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        if (i % 2 == 0 )
                        {
                            pares++;
                        }
                        else
                        {
                            impares++;
                        }
                        i++;
                    } while (i<=n);

                    Console.WriteLine("Resultados");
					Console.WriteLine("Pares: " + pares);
					Console.WriteLine("Impares: " + impares);
                    break;
                case 3:
                    Console.WriteLine("Mostrando: Ejemplo For-Next");
					Console.WriteLine("Dado como Datos N numeros enteros");
					Console.WriteLine("Obtenga el numero de ceros que hay dentro de la lista");
                    
                    int m=0, x=0, y=0, CuentaCeros=0;
					
					Console.WriteLine("De que tamano deseas tu lista: ");
					m = Convert.ToInt32(Console.ReadLine());
					
					for(x=1; x<=m; x++){
						Console.WriteLine("Ingrese numero");
						y = Convert.ToInt32(Console.ReadLine());
						if(y==0){
                           CuentaCeros++;
                        }
					}
					Console.WriteLine("Usted ingreso cero " + CuentaCeros + " veces");
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar el sistema, vuelva pronto");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta, ingrese una nueva");
                    break;
            }
            Console.ReadKey();
        } while (opc!=4);
    }
}
