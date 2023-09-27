# M4BAN-Prueba-2

## Introducción

Una empresa de baldosas quiere programar un sistema para calcular los costos de sus trabajos. Las baldosas pueden ser cuadradas o circulares. Además, pueden ser de uno de los siguientes materiales: Cemento ($5) o Ladrillo ($10). El precio de cada baldosa se calcula como área de la baldosa * precio del metro cuadrado * precio del material.

## Se pide:

1. Forkear el repo del ejercicio.
2. Conectar el proyecto de test con el proyecto de backend.
3. Modelar el problema usando TDD. El modelado debe tener una clase CostCalculator con un único método el cual recibe dos parámetros: una lista de baldosas y el precio por metro cuadrado, y devuelve el costo total.
4. En TryOut, se pide calcular el precio de 3 baldosas cuadradas de 2x2 de cemento y 1 circular de radio=3 de ladrillo, a 4 pesos el metro cuadrado.

## Contestar en el README

5. ¿Qué archivo se modificó para lograr el ejercicio 2?											
	Los archivos modificados fueron bussiness.cs y bussinessTest.cs por la utilizacion de los tests y la creacion de las clases.

6. En su código, ¿Qué pasa si alguien desea agregar un nuevo tipo de figura?
	Teoricamente si lo hubiera hecho, hubiera creado para cada forma una clase que hereda otra clase material el cual pueda recibir la base, la altura y el material para que asi calcule el area y el precio de la baldosa. Luego en la clase CostCalculator, hubiera creado un metodo que reciba una lista de baldosas y el precio por metro cuadrado, y devuelve el costo total. En el metodo hubiera creado una variable que guarde el costo total y luego hubiera creado un foreach que recorra la lista de baldosas y que por cada baldosa que encuentre, sume el costo total de la baldosa a la variable que guarda el costo total. Luego hubiera retornado el costo total.
	
7. Cuando usted compila su código, dotnet genera archivos .DLL, ¿Qué contienen esos archivos y cómo son usados por el CLR?
	Cuando genero el código, dotnet genera archivos .DLL que contienen el código compilado de la aplicación, esta escrito en codigo legible por el humano independiente a como este escrito. Estos archivos son usados por el CLR para ejecutar la aplicación.