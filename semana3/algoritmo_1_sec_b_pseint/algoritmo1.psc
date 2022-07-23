Algoritmo Algoritmo1
	//{ Lectura de datos }
	Definir a Como Entero
	Definir b Como Entero
	Definir r Como Real
	Definir exponente Como Entero
	
	exponente <- 2
	
	Escribir "Ingrese el valor de a: "
	Leer a
	
	Escribir "Ingrese el valor b: "
	Leer b
	
	Si (a=0) | (a Es Caracter | b Es Caracter ) Entonces
		Escribir "Usted ha ingresando un valor incorrecto"
	SiNo
		r<- ((a+b)^exponente)/(3*a)
		Escribir "El resultado de la operacion es: " . r
	Fin Si
	
FinAlgoritmo
