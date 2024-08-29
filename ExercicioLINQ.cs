using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    //Adicione uma lista de produtos com propriedades Nome e Preço.Faça uma consulta LINQ para encontrar os produtos cujo preço é superior à média de todos os produtos.

    public class Exercicio
    {

        public void ExibirConsultaProduto()
        {
            var Produtos = new List<Produtos>
            {
                new Produtos { Nome = "Arroz", Preco = 20.00 },
                new Produtos { Nome = "Feijão", Preco = 25.00 },
                new Produtos { Nome = "Macarrao", Preco = 22.00 },
                new Produtos { Nome = "Filé", Preco = 28.00},
                new Produtos { Nome = "Café", Preco = 18.00 },
                new Produtos { Nome = "Manteiga", Preco = 13.00 },
                new Produtos { Nome = "Ovo", Preco = 16.00 },

            };

            var precoMedio = Produtos.Average(p => p.Preco);
            var precoMaiorPrecoMedio = Produtos.Where(p => p.Preco > precoMedio);
            foreach (var produto in precoMaiorPrecoMedio)
            {
                Console.WriteLine($"O nome do produto e {produto.Nome}, o preço do produto e {produto.Preco}");
            }
        }
    }
        public class Produtos
        {
            public string? Nome;
            public double? Preco;
        }
    }


    
