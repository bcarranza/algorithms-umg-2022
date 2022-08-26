Algoritmo estructuras_iterativas
Definir opc Como Entero	
Repetir
	Limpiar Pantalla
	Escribir "Menu Principal"
	Escribir "1. Ejemplo While"
	Escribir "2. Ejemplo Do-While"
	Escribir "3. Ejemplo For-Next"
	Escribir "4. Salir"
	Escribir "Escriba su opcion: "
	Leer opc
	Segun opc Hacer
		1:
			Escribir "Ejectuando: Gastos de viaje"
			Escribir "Supongamos que debemos obtener una suma de gastos"
			Escribir "que hicimos en nuestro ultimo viaje, pero no sabemos"
			Escribir "exactamente cuantos fueron. Los datos son expresados"
			Escribir "Datos: Gasto1, Gasto2, Gasto3...GastoN, -1"
			Esperar Tecla
			
			Definir SumGas Como Real
			Definir Gasto Como Real
			SumGas<-0
			Gasto<-0
			Mientras Gasto<>-1 Hacer
				Escribir "Ingrese nuevo gasto: "
				Leer Gasto
				SumGas=SumGas+Gasto
				Escribir "Gasto acumulado: " . SumGas
			Fin Mientras
		2:
			Escribir "Mostrando: Ejemplo Do-While"
			Escribir "Conteo de pares e impares"
			Escribir "Ingresaremos un numero "
			Escribir "al final mostraremos cuantos numeros"
			Escribir "pares y cuantos impares se ingresaron"
			Esperar Tecla
			
			Definir n Como Entero
	
			Definir i Como Entero
			Definir pares Como Entero
			Definir impares Como Entero
			
			n<-0 //control del tamano de la lista
			i<-1 //control del acumulador de la lista
			pares<-0
			impares<-0
			
			Escribir "Ingrese el tamano de la lista: "
			Leer n
			
			Repetir
				si i mod 2 == 0 Entonces
					pares<-pares+1
				SiNo
					impares<-impares+1
				FinSi
				i<-i+1
			Hasta Que i>n
			Escribir "Resultados"
			Escribir "Pares: " . pares
			Escribir "Impares: " . impares
			Esperar Tecla
			
		3:
			Escribir "Mostrando: Ejemplo For-Next"
			Escribir "Dado como Datos N numeros enteros"
			Escribir "Obtenga el numero de ceros que hay dentro de la lista"
			
			Definir n Como Entero
			Definir x Como Entero
			Definir CueCer Como Entero
			Escribir "De que tamano deseas tu lista"
			Leer n
			
			Para i<-1 Hasta n Hacer
				Escribir "Ingrese numero"
				Leer x
				Si x=0 Entonces
					CueCer<-CueCer+1
				FinSi
			Fin Para
			Escribir "Usted ingreso cero " , CueCer , " veces"
			Esperar Tecla
		4: 
			Escribir "Gracias por usar el sistema, vuelva pronto"
			Esperar Tecla
		De Otro Modo:
			Escribir "Opcion incorrecta, ingrese una nueva"
			Esperar Tecla
	Fin Segun
Hasta Que opc=4
FinAlgoritmo
