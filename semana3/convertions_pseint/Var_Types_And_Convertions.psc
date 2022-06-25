Algoritmo Var_Types_And_Convertions
//Variable types
Definir cliente Como Caracter	
Definir edad Como Entero
Definir valido Como Logico
Definir monto Como Real


Definir textoTemporal Como Caracter
//Asignando valores
cliente<-"Jose Ramirez"
edad<-20
valido<-Verdadero
monto<-4000.50

//Imprimir 
Escribir cliente
Escribir edad
Escribir valido
Escribir monto


//Leeamos un valor de la consola (generando errores)
//Escribir "Ingrese el cliente: " 
//Leer cliente

//Escribir "Ingrese edad"
//Leer edad  //Error por conversion

//Escribir "Es un cliente valido"
//Leer valido

//Escribir "Ingrese el salario del cliente" 
//Leer monto

//Imprimir 
//Escribir cliente
//Escribir edad
//Escribir valido
//Escribir monto

//Leeamos un valor de la consola (conversiones correctas)
Escribir "Ingrese el cliente: " 
Leer cliente  //Un valor cadena no se necesita conversion ya que la lectura de consola es del mismo tipo

Escribir "Ingrese edad"
Leer textoTemporal
edad<-ConvertirANumero(textoTemporal)

Escribir "Es un cliente valido"
Leer textoTemporal
Si Mayusculas(textoTemporal) =='SI'  Entonces
	valido<-Verdadero
SiNo
	Si Mayusculas(textoTemporal) =='NO' Entonces
		valido<-Falso
	SiNo
		Escribir "Valor invalido"
	Fin Si
Fin Si

Escribir "Ingrese el salario del cliente" 
Leer textoTemporal
monto<-ConvertirANumero(textoTemporal)

//Imprimir 
Escribir cliente
Escribir edad
Escribir valido
Escribir monto


	
FinAlgoritmo
