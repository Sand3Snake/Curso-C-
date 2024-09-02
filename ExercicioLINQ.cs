using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    /*

      public class Exercicio
     {
     public void ExibirConsulta()
     {
        var Pessoas = new List<PessoaLinq>
        {
           new PessoaLinq { Nome = "Suelen", Idade = 22 },
           new PessoaLinq { Nome = "Lia", Idade = 20 },
           new PessoaLinq { Nome = "Zelita", Idade = 19 },
           new PessoaLinq { Nome = "Arthur", Idade = 25 },
           new PessoaLinq { Nome = "Ruan", Idade = 18 },
           new PessoaLinq { Nome = "Leo", Idade = 18 },
           new PessoaLinq { Nome = "Davi", Idade = 30 },
           new PessoaLinq { Nome = "Thiago", Idade = 27 },
           new PessoaLinq { Nome = "Marcos", Idade = 18 },
           new PessoaLinq { Nome = "Eric", Idade = 18 }
         };

           var pessoasInicoNomeAmaiorque25 = Pessoas.Where(p => p.Nome.StartsWith("A") && p.Idade > 25);

           foreach (var pessoas in pessoasInicoNomeAmaiorque25)
           {
              Console.WriteLine(pessoas);
           }
     }
         }
            public class PessoaLinq
         {
             public string? Nome;
             public int? Idade { get; set; }

    }/*

    /*  public class Exercicio
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
            Console.WriteLine($"O nome da pessoa e {produto.Nome} idade da pessoa e {produto.Preco}");
        }
    }
    }
        public class Produtos
    {
        public string? Nome;
        public double? Preco;

    }

        public class PessoaNova
    {
    public string Nome;
    }
    public class Exercicio
    {
    public void Seila()
    {
        var ListaPessoas = new List<PessoaNova>
        {
            new PessoaNova{Nome = "Rodrigo"},
            new PessoaNova{Nome = "Lia"},
            new PessoaNova{Nome = "Zeze"},
            new PessoaNova{Nome = "Leo"},
            new PessoaNova{Nome = "Arthur"},
            new PessoaNova{Nome = "Suuh"}

        };

        var PessoasOrdenadas = ListaPessoas.OrderByDescending(x => x.Nome).ToList();

        foreach (var pessoa in PessoasOrdenadas)
        {
            Console.WriteLine($"{pessoa.Nome}");
        }
    }
    }*/


    /*public class PessoaNova
    {
        public string Nome;
        public string Cidade;
        public int Idade;
    }

    public class Exercicio
    {
        public void Seila()
        {
            var pessoasList = new List<PessoaNova>
    {
            new PessoaNova{Nome="Rodrigo", Cidade = "Brasilia" , Idade = 43 },
            new PessoaNova{Nome="Lia", Cidade = "São Paulo" , Idade = 19 },
            new PessoaNova{Nome="Zeze", Cidade = "Brasilia" , Idade = 18 },
            new PessoaNova{Nome="Arthur", Cidade = "Brasilia" , Idade = 29 },
            new PessoaNova{Nome="Davi", Cidade = "São Paulo" , Idade = 21 },
            new PessoaNova{Nome="Leo", Cidade = "Belem" , Idade = 19 },
            new PessoaNova{Nome="Suuh", Cidade = "Belem" , Idade = 22 }
    };

            var pessoaMaisJovemPorCidade = pessoasList
            .GroupBy(p => p.Cidade)
            .Select(grupo => grupo.OrderBy(p => p.Idade).First());

            Console.WriteLine("Pessoa mais jovem por cidade:");
            foreach (var pessoa in pessoaMaisJovemPorCidade)
            {
              Console.WriteLine($"{pessoa.Nome} de {pessoa.Cidade} com {pessoa.Idade} anos");
     }*/


    /*public class Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
    }

    public class Exercicio
    {
        public void Seila()
        {
            var LivrosList = new List<Livro>
     {
             new Livro{Titulo="Se houver um amanhã", Autor = "Sidney Shadow" , AnoPublicacao = 1985 },
             new Livro{Titulo="O reverso da medalha", Autor = "Sidney Shadow" , AnoPublicacao = 1982 },
             new Livro{Titulo="O outro lado da meia noite", Autor = "Sidney Shadow" , AnoPublicacao = 1973 },
             new Livro{Titulo="Me diga seus sonhos", Autor = "Sidney Shadow" , AnoPublicacao = 1998 },
     };

            var receberLivros = LivrosList.Where(p => p.AnoPublicacao > 1980).OrderBy(x => x.AnoPublicacao).ToList();

            foreach (var livro in receberLivros)
            {
                Console.WriteLine($"{livro.Titulo}, {livro.Autor}, {livro.AnoPublicacao}");
            }

        }*/


    /* public class PessoaNova
     {
         public string? Nome { get; set; }
         public int Idade { get; set; }
         public string? Cidade { get; set; }

     }

     public class Exercicio
     {
         public void ExibirResultado(string cidade)
         {
             var ListPessoas = new List<PessoaNova>
             {
                 new PessoaNova{Nome = "Rodrigo", Idade = 43, Cidade = "Brasilia"},
                 new PessoaNova{Nome = "Iago", Idade = 24, Cidade = "Brasilia"},
                 new PessoaNova{Nome = "Josué", Idade = 25, Cidade = "São Paulo"},
                 new PessoaNova{Nome = "Sebastião", Idade = 20, Cidade = "São Paulo"},
             };

             var pessoasPorCidade = ListPessoas.Where(p => p.Cidade == cidade).ToList();
             Console.WriteLine($"As pessoas cadastradas na {cidade} são:");
             foreach ( var pessoa in pessoasPorCidade )
             {
                 Console.WriteLine($" {pessoa.Nome}, {pessoa.Idade}, {pessoa.Cidade}");
             }
         }
     }


    } */


    /*public class PessoaNova
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cidade { get; set; }

    }

    public class Exercicio
    {
        public void ExibirResultado()
        {
            var ListPessoas = new List<PessoaNova>
            {
                new PessoaNova{Nome = "Rodrigo", Idade = 43, Cidade = "Brasilia"},
                new PessoaNova{Nome = "Iago", Idade = 24, Cidade = "Brasilia"},
                new PessoaNova{Nome = "Josué", Idade = 25, Cidade = "São Paulo"},
                new PessoaNova{Nome = "Sebastião", Idade = 20, Cidade = "São Paulo"},
            };

            var pessoasMaisVelhasPorCidade = ListPessoas
            .GroupBy(p => p.Cidade)
            .Select(grupo => grupo.OrderByDescending(p => p.Idade)
            .First());

            Console.WriteLine($"A pessoa mais velha por cidade:");
            foreach (var pessoa in pessoasMaisVelhasPorCidade)
            {
                Console.WriteLine($" {pessoa.Nome}, {pessoa.Idade}, {pessoa.Cidade}");
            }
        }
    }
    }*/


    /*public class PessoaNova
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cidade { get; set; }
        public decimal? Salario { get; set; }


    }

    public class Exercicio
    {
        public void ExibirResultado()
        {
            var ListPessoas = new List<PessoaNova>
        {
            new PessoaNova{Nome = "Rodrigo", Idade = 43,Cidade = "Brasilia", Salario = 1.000m},
            new PessoaNova{Nome = "Iago", Idade = 24, Cidade = "Brasilia", Salario = 1.250m},
            new PessoaNova{Nome = "Josué", Idade = 25, Cidade = "São Paulo", Salario = 1.421m },
            new PessoaNova{Nome = "Sebastião", Idade = 20, Cidade = "São Paulo", Salario = 1.618m}
        };

            var pessoaMediaSalarial = ListPessoas.Average(p => p.Salario);

            {
                Console.WriteLine($" A media salarial e: {pessoaMediaSalarial}");
            }
        }
    }

    }*/

    /*public class PessoaNova
    {
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Cidade { get; set; }
    public decimal? Salario { get; set; }


    }

    public class Exercicio
{
   public void ExibirResultado()
   {
       var ListPessoas = new List<PessoaNova>
   {
       new PessoaNova{Nome = "Rodrigo", Idade = 43,Cidade = "Brasilia", Salario = 1.000m},
       new PessoaNova{Nome = "Iago", Idade = 24, Cidade = "Brasilia", Salario = 1.250m},
       new PessoaNova{Nome = "Josué", Idade = 25, Cidade = "São Paulo", Salario = 1.421m },
       new PessoaNova{Nome = "Sebastião", Idade = 20, Cidade = "São Paulo", Salario = 1.618m}
   };

            var pessoaEntre20e30 = ListPessoas
            .Where(p => p.Idade >= 20 && p.Idade <= 30)
            .OrderBy(p => p.Nome)
            .Select(p => p.Nome);

            foreach (var pessoa in pessoaEntre20e30)
            {
                Console.WriteLine($"{pessoa}");
            }
      
    }
}

}*/

    /*public class PessoaNova
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cidade { get; set; }
        public decimal? Salario { get; set; }


    }

    public class Exercicio
    {
        public void ExibirResultado()
        {
            var ListPessoas = new List<PessoaNova>
   {
       new PessoaNova{Nome = "Rodrigo", Idade = 43,Cidade = "Brasilia", Salario = 1.000m},
       new PessoaNova{Nome = "Iago", Idade = 24, Cidade = "Brasilia", Salario = 1.250m},
       new PessoaNova{Nome = "Josué", Idade = 25, Cidade = "São Paulo", Salario = 1.421m },
       new PessoaNova{Nome = "Sebastião", Idade = 20, Cidade = "São Paulo", Salario = 1.618m}
   };

            var quantidadePessoasAcimaDe30 = ListPessoas.Count(p => p.Idade > 30);

            Console.WriteLine($"A quantidade de pessoas na lista e: {quantidadePessoasAcimaDe30}");
            
        }
    }
    */

}













