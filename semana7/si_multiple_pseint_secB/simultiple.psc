Algoritmo Residuo
	Definir  num Como Entero
	Definir  v_valor Como Entero
	Definir  resultado Como Entero
	
	Escribir "Ingrese el numero de opcion" 
	Leer num
	
	Escribir "Ingrese un valor"
	Leer v_valor
	Segun num Hacer
		1:
			resultado<-100*v_valor
		2:
			resultado<-100*v_valor*v_valor
		3:
			resultado<-100/v_valor
		De Otro Modo:
			resultado<-0
	Fin Segun
	Escribir resultado
FinAlgoritmo