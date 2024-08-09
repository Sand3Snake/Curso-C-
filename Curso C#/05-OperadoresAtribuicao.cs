using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class _07_OperadoresAtribuicao
    {
        public static void AtribuicaoSimples()
        {
            int a = 10;
            Console.WriteLine($"Valor de a após atribuição: {a}");
        }
        public static void AtribuicaoSoma()
        {
            int a = 10;
            a += 5;
            Console.WriteLine($"Valor de a após a operação a += 5: {a}");
        }
        public static void AtribuicaoSubtracao()
        {
            int a = 10;
            a -= 3;
            Console.WriteLine($"Valor de a após a operação a -= 3: {a}");
        }
        public static void AtribuicaoMultiplicacao()
        {
            int a = 10;
            a *= 4;
            Console.WriteLine($"Valor de a após a operação a *= 4: {a}");
        }
        public static void AtribuicaoDivisao()
        {
            int a = 20;
            a /= 4;
            Console.WriteLine($"Valor de a após a operação a /= 4: {a}");
        }
        public static void AtribuicaoModulo()
        {
            int a = 20;
            a %= 3;
            Console.WriteLine($"Valor de a após a operação a %= 3: {a}");
        }
        public static void AtribuicaoAnd()
        {
            int a = 12;
            a &= 7;
            Console.WriteLine($"Valor de a após a operação a &= 7: {a}");
        }
        public static void AtribuicaoOr()
        {
            int a = 12;            
            a |= 5;
            Console.WriteLine($"Valor de a após a operação a |= 5: {a}");
        }
        public static void AtribuicaoXor()
        {
            int a = 12;
            a ^= 6;
            Console.WriteLine($"Valor de a após a operação a ^= 6: {a}");
        }
        public static void AtribuicaoDeslocamentoEsquerda()
        {
            int a = 4;
            a <<= 2;
            Console.WriteLine($"Valor de a após a operação a <<= 2: {a}");
        }
        public static void AtribuicaoDeslocamentoDireita()
        {
            int a = 16;
            a >>= 2;
            Console.WriteLine($"Valor de a após a operação a >>= 2: {a}");
        }
    }
}
