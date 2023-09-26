using System;

class EJERCICIO1
{
    static void Main()
    {
        double PI = Math.Truncate(Math.PI);
        Console.WriteLine("PI truncado: " + PI);

        Console.WriteLine("");

        double REDONDEADOARRIBA = Math.Ceiling(Math.PI);
        Console.WriteLine("PI redondeado hacia arriba: " + REDONDEADOARRIBA);

        Console.WriteLine("");

        double REDONDIADOABAJO = Math.Floor(Math.PI);
        Console.WriteLine("PI redondeado hacia abajo: " + REDONDIADOABAJO);
    }
}

// EJERCICIO 1
//ALUMNO: JOSE SAUL SIBRIAN SERRANO