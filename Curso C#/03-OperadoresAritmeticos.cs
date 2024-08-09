using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class OperadoresAritmeticos
    {
        /** Soma = +
            Subtração = -
            Divisão = /
            Multiplicação = *
        */
        public static void Soma()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A soma e: {n1 + n2}");
        }
        public static void Subtracao()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A subtracao e: {n1 - n2}");
        }
        public static void Divisão()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A divisao e: {n1 / n2}");
        }
        public static void Multiplicação()
        {
            int n1 = 1, n2 = 2;
            Console.WriteLine($"A multiplicacao e: {n1 * n2}");
        }
        public static void Resto()
        {
            int n1 = 11, n2 = 2;
            Console.WriteLine($"O resto e: {n1 % n2}");
        }
        public static void Incremento()
        {
            int n1 = 1;
            Console.WriteLine($"O incremento e: {n1++}");
        }
        public static void Decremento()
        {
            int n1 = 1;
            Console.WriteLine($"O decremento e: {n1--}");
        }

    }
}
