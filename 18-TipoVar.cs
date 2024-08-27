using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class VarUsageExample
    {
        public void DemonstrateVarUsage()
        {
            // Exemplo 1: Infer�ncia de Tipo
            var NumeroInteiro = 42; // O compilador infere que o tipo � int
            var NumeroReal = 3.14; // O compilador infere que o tipo � double
            var Texto = "Hello, World!"; // O compilador infere que o tipo � string

            Console.WriteLine($"Numero inteiro: {NumeroInteiro}, Tipo: {NumeroInteiro.GetType()}");
            Console.WriteLine($"Numero real: {NumeroReal}, Tipo: {NumeroReal.GetType()}");
            Console.WriteLine($"Texto: {Texto}, Tipo: {Texto.GetType()}");

            // Exemplo 2: Infer�ncia com Tipos Complexos
            var Pessoa = new NovaPessoa { Nome = "Alice", Idade = 30 }; // O compilador infere o tipo como Pessoa

            Console.WriteLine($"Pessoa Name: {Pessoa.Nome}, Age: {Pessoa.Idade}");

            // Exemplo 3: Uso com Cole��es
            var numeros = new int[] { 1, 2, 3, 4, 5 }; // O compilador infere o tipo como int[]
            var nomes = new List<string> { "Alice", "Bob", "Charlie" }; // O compilador infere o tipo como List<string>

            Console.WriteLine("Numbers:");
            foreach (var number in numeros)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Names:");
            foreach (var name in nomes)
            {
                Console.WriteLine(name);
            }

            // Exemplo 4: N�o pode ser usado sem inicializa��o
            // var uninitializedVar; // Isto resultar� em um erro de compila��o, pois o tipo n�o pode ser inferido sem um valor inicial

            // Exemplo 5: Uso com LINQ
            var query = from n in numeros
                        where n % 2 == 0
                        select n;

            Console.WriteLine("Numeros pares:");
            foreach (var NumerosPares in query)
            {
                Console.WriteLine(NumerosPares);
            }
        }
    }

    // Exemplo de classe usada no exemplo
    public class NovaPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

}
