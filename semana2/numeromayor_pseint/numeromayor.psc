Algoritmo NumeroMayor
Definir a Como Entero
Definir b Como Entero
Definir c Como Entero
	
Escribir "Introduzca 3 numeros para calcular cual es el mayor, menor y medio"	
Escribir "Cual es el numero A?"
Leer a

Escribir "Cual es el numero B?"
Leer b

Escribir "Cual es el numero C?"
Leer c

Si a>b Entonces
	Si a>c Entonces
		Escribir "A es el mayor"
	SiNo
		Escribir "C es el mayor"
	FinSi
SiNo
	Si c>b
		Escribir "C es el mayor"
	SiNo
		Escribir "B es el mayor"
	FinSi
FinSi