using System;

double s = 20; 
double suma = 0; 
double valor = 2;

for (int i = 1; i <= s; i++)
{
    double cuadrado = Math.Pow(i, valor); 
    suma += cuadrado; 
}

Console.WriteLine("***********************************************************************************************");

Console.WriteLine("");

Console.WriteLine("La cantidad de Digitos a iniciar es de: " + s + ". Y la Suma total de los Digitos es: " + suma);

Console.WriteLine("");

Console.WriteLine("***********************************************************************************************");


//EJERCICIO 3
//ALUMNO: JOSE SAUL SIBRIAN SERRANO