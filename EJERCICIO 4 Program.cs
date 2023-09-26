using System;

Console.Write("Ingrese el valor de A: ");
double A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.Write("Ingrese el valor de B: ");
double B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.Write("Ingrese el valor de C: ");
double C = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("**************************************************");

Console.WriteLine("");

Console.WriteLine("Ejecutando la funcion Math.Sqrt");

Console.WriteLine("");

Console.WriteLine("**************************************************");


double raiz = B * B - 4 * A * C;
double x1 = (-B + Math.Sqrt(raiz)) / (2 * A);
double x2 = (-B - Math.Sqrt(raiz)) / (2 * A);

Console.WriteLine("");

Console.WriteLine("El resultado de x1 es: " + x1);

Console.WriteLine("");

Console.WriteLine("El resultado de x2 es: " + x2);

Console.WriteLine("");

Console.WriteLine("**************************************************");

//EJERCICIO 4
//ALUMNO: JOSE SAUL SIBRIAN SERRANO