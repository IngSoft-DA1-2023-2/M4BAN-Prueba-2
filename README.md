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
El archivo que se modifico fue el archivo BusinessLogic.test, en la seccion item group se conecto con el backend

6. En su código, ¿Qué pasa si alguien desea agregar un nuevo tipo de figura?
Para agregar una nueva figura, se debe crear una nueva clase en  BusinessLogic, con el nombre de la figura, luego debe crear los test necesarios para esa clase

7. Cuando usted compila su código, dotnet genera archivos .DLL, ¿Qué contienen esos archivos y cómo son usados por el CLR?

Los archivos .DLL en .NET contienen código ejecutable, metadatos y recursos que pueden ser compartidos y reutilizados por múltiples aplicaciones. 
Cuando una aplicación .NET hace referencia a un archivo .DLL, el (CLR) se encarga de cargar, compilar y gestionar la ejecución de código contenido en el archivo.
Esto permite la reutilización de funcionalidad y la resolución de dependencias de ensamblados.