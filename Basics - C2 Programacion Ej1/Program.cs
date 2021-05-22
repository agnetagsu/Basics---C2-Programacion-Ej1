using System;

namespace Basics___C2_Programacion_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 32;
            int B = 19;
            int suma = A + B;
            int resta = A - B;
            double multiplicacion = A * B;
            double division = A / B;
            int resto = A % B;

            Console.WriteLine("A es {0} y B es {1}\n", A,B);
            Console.WriteLine("La Suma A+B es {0}, la Resta A-B es {1}, la Multiplicación A*B es {2}, la División A/B es {3} y el Resto A%B es {4}",suma,resta,multiplicacion,division,resto);
        }
    }
}
