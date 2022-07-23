Algoritmo Algoritmo1
	//Seccion de definicion de variables
	Definir a Como Entero
	Definir b Como Entero
	Definir result Como Real
	
	//Solicitud de valores al usuario (incluye la lectura de los mismos)
	Escribir "Ingrese el valor de a"
	Leer a
	
	//Validacion de la operacion indefinida
	Si a>0 Entonces
		
		Escribir "Ingrese el valor de b"
		Leer b
		
		//Proceso 
		result<-((a + b)^2)/(3*a)
		
		//Impresion de los resultados.
		Escribir "El resultado de la operacion es: " . result 
		
	SiNo
		Escribir "Esta operacion no es correcta debido a que no existe en el conjunto de los reales."
	Fin Si
	
	
FinAlgoritmo
