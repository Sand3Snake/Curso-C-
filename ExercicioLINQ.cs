using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{

    public class Livro
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

        }
    
    }
}





