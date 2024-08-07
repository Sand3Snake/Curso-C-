using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class ExercicioOperadoresAritmeticos

    {
        /**static void Main()
         {
             // Solicita o primeiro número ao usuário
             Console.Write("Digite o primeiro número inteiro: ");
             int numero1 = int.Parse(Console.ReadLine());

             // Solicita o segundo número ao usuário
             Console.Write("Digite o segundo número inteiro: ");
             int numero2 = int.Parse(Console.ReadLine());

             // Calcula a soma dos dois números
             int soma = numero1 + numero2;

             // Exibe o resultado com uma mensagem informativa
             Console.WriteLine("A soma dos dois números é: " + soma);
          
         static void Main()
     
            // Solicita o primeiro número ao usuário
             Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita o segundo número ao usuário
            Console.Write("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Calcula a diferença entre o primeiro e o segundo número
             int diferenca = numero1 - numero2;

            // Exibe o resultado com uma mensagem informativa
            Console.WriteLine("A diferença entre o primeiro e o segundo número é: " + diferenca);


         static void Main()
     
            // Solicita o primeiro número ao usuário
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita o segundo número ao usuário
            Console.Write("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Calcula a multiplicação dos dois números
            int multiplicacao = numero1 * numero2;

            // Exibe o resultado com uma mensagem informativa
            Console.WriteLine("A multiplicação dos dois números é: " + multiplicacao);


         static void Main()
     
            // Solicita o primeiro número ao usuário
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita o segundo número ao usuário
            Console.Write("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Verifica se o segundo número é zero
            if (numero2 == 0)
         {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
         }
         else
         {
            // Calcula a divisão dos dois números
            double resultado = (double)numero1 / numero2;

            // Exibe o resultado com uma mensagem informativa
            Console.WriteLine("A divisão do primeiro número pelo segundo é: " + resultado);

         static void Main()
    
            // Solicita o primeiro número ao usuário
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita o segundo número ao usuário
            Console.Write("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Verifica se o segundo número é zero
            if (numero2 == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
        else
        {
            // Calcula o resto da divisão dos dois números
            int resto = numero1 % numero2;

            // Exibe o resultado com uma mensagem informativa
            Console.WriteLine("O resto da divisão do primeiro número pelo segundo é: " + resto);
        }

         static void Main()
    
            // Solicita um número inteiro ao usuário
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Incrementa o número usando o operador ++
            numero++;

            // Exibe o número incrementado com uma mensagem informativa
            Console.WriteLine("O número incrementado em 1 é: " + numero);


         static void Main()
       {
            // Solicita ao usuário que insira um número inteiro
            Console.Write("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Decrementa o número em 1
            numero--;  // Utilizando o operador de decremento --

            // Exibe o número decrementado
            Console.WriteLine("O número decrementado em 1 é: " + numero);
       }

         static void Main()
       {
            // Solicita ao usuário que insira o primeiro número inteiro
            Console.Write("Insira o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o segundo número inteiro
            Console.Write("Insira o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Calcula a média dos dois números
            double media = (numero1 + numero2) / 2.0;

            // Exibe a média com uma mensagem informativa
            Console.WriteLine($"A média dos números {numero1} e {numero2} é: {media}");
       }

         static void Main()
       {
            // Solicita ao usuário que insira o primeiro número inteiro
            Console.Write("Insira o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o segundo número inteiro
            Console.Write("Insira o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o terceiro número inteiro
            Console.Write("Insira o terceiro número inteiro: ");
            int numero3 = int.Parse(Console.ReadLine());

            // Calcula a soma dos dois primeiros números
            int soma = numero1 + numero2;

            // Subtrai o terceiro número do resultado da soma
            int resultado = soma - numero3;

            // Exibe o resultado com uma mensagem explicativa
            Console.WriteLine($"A soma dos dois primeiros números ({numero1} e {numero2}) é {soma}, e subtraindo o terceiro número ({numero3}), o resultado é: {resultado}");
       }

         static void Main()
       {
            // Solicita ao usuário que insira o primeiro número inteiro
            Console.Write("Insira o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o segundo número inteiro
            Console.Write("Insira o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Calcula o quadrado do primeiro número
            int quadradoNumero1 = numero1 * numero1;

            // Soma o quadrado do primeiro número com o segundo número
            int resultado = quadradoNumero1 + numero2;

            // Exibe o resultado com uma mensagem explicativa
            Console.WriteLine($"O quadrado do primeiro número ({numero1}^2) é {quadradoNumero1}, e somado ao segundo número ({numero2}), o resultado é: {resultado}");
       }

          static void Main()
       {
            // Solicita ao usuário que insira um valor
            Console.Write("Insira um valor: ");
            double valor = double.Parse(Console.ReadLine());

            // Calcula o dobro do valor
            double dobro = valor * 2;

            // Calcula a metade do valor
            double metade = valor / 2;

            // Exibe o dobro e a metade do valor com mensagens explicativas
            Console.WriteLine($"O dobro do valor {valor} é: {dobro}");
            Console.WriteLine($"A metade do valor {valor} é: {metade}");
       }

         static void Main()
       {
            // Solicita ao usuário que insira o primeiro número inteiro
            Console.Write("Insira o primeiro número inteiro (a): ");
            int a = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o segundo número inteiro
            Console.Write("Insira o segundo número inteiro (b): ");
            int b = int.Parse(Console.ReadLine());

            // Calcula o resultado da expressão (a + b) * (a - b)
            int resultado = (a + b) * (a - b);
            
            // Exibe o resultado com uma mensagem informativa
            Console.WriteLine($"O resultado da expressão ({a} + {b}) * ({a} - {b}) é: {resultado}");
      }
        
         static void Main()
      {
            // Solicita ao usuário que insira o primeiro número inteiro
            Console.Write("Insira o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o segundo número inteiro
            Console.Write("Insira o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Calcula o quadrado do primeiro número
            int quadradoNumero1 = numero1 * numero1;

            // Calcula o quadrado do segundo número
            int quadradoNumero2 = numero2 * numero2;

            // Calcula a soma dos quadrados dos dois números
            int somaQuadrados = quadradoNumero1 + quadradoNumero2;
            
            // Exibe o resultado com uma mensagem explicativa
            Console.WriteLine($"A soma do quadrado do primeiro número ({numero1}^2) e o quadrado do segundo número ({numero2}^2) é: {somaQuadrados}");
      }

        static void Main()
      {
            // Solicita ao usuário que insira um número inteiro
            Console.Write("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Calcula o valor do número ao cubo
            int cubo = numero * numero * numero;

            // Exibe o resultado com uma mensagem explicativa
            Console.WriteLine($"O valor de {numero} ao cubo é: {cubo}");
      }

         static void Main()
      {
            // Solicita ao usuário que insira o primeiro número inteiro
            Console.Write("Insira o primeiro número inteiro (a): ");
            int a = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o segundo número inteiro
            Console.Write("Insira o segundo número inteiro (b): ");
            int b = int.Parse(Console.ReadLine());

            // Verifica se o segundo número é zero para evitar divisão por zero
        if (b == 0)
        {
            Console.WriteLine("Erro: O segundo número (b) não pode ser zero, pois resulta em divisão por zero.");
        }
        else
        {
            // Calcula o resultado da expressão a * (b + a) / b
            double resultado = (double)(a * (b + a)) / b;

            // Exibe o resultado com uma mensagem informativa
            Console.WriteLine($"O resultado da expressão {a} * ({b} + {a}) / {b} é: {resultado}");
        }

        static void Main()
     {
            // Solicita ao usuário que insira um número inteiro
            Console.Write("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Calcula a diferença entre o número e 5
            int diferenca = numero - 5;

            // Calcula o quadrado da diferença
            int quadradoDiferenca = diferenca * diferenca;

            // Exibe o resultado com uma mensagem explicativa
            Console.WriteLine($"O quadrado da diferença entre {numero} e 5 é: {quadradoDiferenca}");
     }

        
        static void Main()
     {
            // Solicita ao usuário que insira o primeiro número inteiro
            Console.Write("Insira o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o segundo número inteiro
            Console.Write("Insira o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Calcula a média aritmética dos dois números
            double media = (numero1 + numero2) / 2.0;

            // Exibe a média com uma mensagem explicativa
            Console.WriteLine($"A média aritmética entre {numero1} e {numero2} é: {media}");
     }

        static void Main()
     {
            // Taxa de câmbio fixa
            const double taxaCambio = 5.0;

            // Solicita ao usuário que insira um valor em reais
            Console.Write("Insira um valor em reais: ");
            double valorReais = double.Parse(Console.ReadLine());

            // Converte o valor em reais para dólares
            double valorDolares = valorReais / taxaCambio;

            // Exibe o resultado com uma mensagem explicativa
            Console.WriteLine($"O valor de R${valorReais} em dólares (considerando a taxa de câmbio de R${taxaCambio} por dólar) é: ${valorDolares:F2}");
     } 

        static void Main()
     {
            // Solicita ao usuário que insira a quantidade de dias
            Console.Write("Insira a quantidade de dias: ");
            int quantidadeDias = int.Parse(Console.ReadLine());
            
            // Calcula a quantidade total de horas
            int totalHoras = quantidadeDias * 24;

            // Exibe o resultado com uma mensagem explicativa
            Console.WriteLine($"A quantidade total de horas em {quantidadeDias} dias é: {totalHoras} horas.");
     }


        static void Main()
     {
             // Solicita ao usuário que insira a quantidade de horas
            Console.Write("Insira a quantidade de horas: ");
            int horas = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira a quantidade de minutos
            Console.Write("Insira a quantidade de minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            // Calcula o total de minutos
            int totalMinutos = (horas * 60) + minutos;

            // Exibe o resultado com uma mensagem explicativa
            Console.WriteLine($"O total em minutos, considerando {horas} horas e {minutos} minutos, é: {totalMinutos} minutos.");
     }

     
     */

    }

}
