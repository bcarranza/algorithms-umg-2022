using System;
					
public class Program
{
	public static void Main()
	{
		int opc;
		opc = 0;
		do{
			Console.Clear();
			Console.WriteLine("Menu Principal");
			Console.WriteLine("1. Ejemplo While");
			Console.WriteLine("2. Ejemplo Do-While");
			Console.WriteLine("3. Ejemplo For-Next");
			Console.WriteLine("4. Salir");
			Console.WriteLine("Escriba su opcion: ");
			opc = Convert.ToInt32(Console.ReadLine());
			switch (opc)
			{
				case 1:
					Console.WriteLine("Ejectuando: Gastos de viaje");
					Console.WriteLine("Supongamos que debemos obtener una suma de gastos");
					Console.WriteLine("que hicimos en nuestro ultimo viaje, pero no sabemos");
					Console.WriteLine("exactamente cuantos fueron. Los datos son expresados");
					Console.WriteLine("Datos: Gasto1, Gasto2, Gasto3...GastoN, -1");
					Console.ReadKey();
					
					double SumGas;
					double Gasto;
					SumGas = 0;
					Gasto = 0;
					
					while(Gasto!=-1)
					{
						Console.WriteLine("Ingrese nuevo gasto: ");
						Gasto = Convert.ToDouble(Console.ReadLine());
						SumGas=SumGas+Gasto;
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
			
					int n,i,pares,impares;
					n=0;
					i=0;
					pares=0;
					impares=0;
			
					Console.WriteLine("Ingrese el tamano de la lista: ");
					n = Convert.ToInt32(Console.ReadLine());
					
					do{
						if(i % 2 == 0){
							pares = pares + 1;
						}
						else{
							impares = impares + 1;
						}
						i = i + 1;
					}while(i<n);
			
					Console.WriteLine("Resultados");
					Console.WriteLine("Pares: " + pares);
					Console.WriteLine("Impares: " + impares);
					Console.ReadKey();
					break;
				case 3:
					Console.WriteLine("Mostrando: Ejemplo For-Next");
					Console.WriteLine("Dado como Datos N numeros enteros");
					Console.WriteLine("Obtenga el numero de ceros que hay dentro de la lista");
					
					int m, x, y, CueCer;
					m=0;
					x=0;
                    y=0;
					CueCer=0;
					
					Console.WriteLine("De que tamano deseas tu lista");
					m = Convert.ToInt32(Console.ReadLine());
					
					for(x=1; x<=m; x++){
						Console.WriteLine("Ingrese numero");
						y = Convert.ToInt32(Console.ReadLine());
						if(y==0){
                           CueCer=CueCer+1; 
                        }
					}
					Console.WriteLine("Usted ingreso cero " + CueCer + " veces");
					Console.ReadKey();
					break;
				case 4:
					Console.WriteLine("Gracias por usar el sistema, vuelva pronto");
					Console.ReadKey();
					break;
				default:
					Console.WriteLine("Opcion incorrecta, ingrese una nueva");
					Console.ReadKey();
					break;
			}
		}while(opc!=4);
	}
}