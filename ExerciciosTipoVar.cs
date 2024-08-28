using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    //Declare uma variável de cada um dos seguintes tipos usando var e atribua a elas valores apropriados. Depois, exiba o tipo da variável usando GetType() para confirmar a inferência do tipo.

    public class Exercicios
    {
        public void Metodo()
        {
            var numero = 0;
            var palavra = "hamburguer";
            Console.WriteLine(palavra.GetType());
            Console.WriteLine(numero.ToString());
        }
    }

}
    //Crie uma lista de inteiros e use um método LINQ para ordenar a lista em ordem crescente. Declare a variável que armazena o resultado usando var.

    public class Atividade
{
        public void Lista()
    {
        var mostrar = new List<Frutas>();
        {
            new Frutas { NomeFruta = "Amora" };
            new Frutas { NomeFruta = "Ameixa" };
            new Frutas { NomeFruta = "Abacaxi" };
            new Frutas { NomeFruta = "Banana" };


        }
        foreach (var fruta in mostrar)
        {
            Console.WriteLine(fruta.NomeFruta);
        }
    }

    public class Frutas
    {
        public string NomeFruta;
    }

}

    //Crie um tipo anônimo usando var para armazenar informações de uma pessoa (nome e idade) e exiba essas informações.

    public class PessoaSuu
    {
        public void Mostrar()
    {
        var pessoa = new{ Nome = "Maria", Idade = 25 };
        Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade}");
    }
    
        
}

    //Declare uma variável var para um tipo complexo, como um Dictionary ou uma instância de uma classe personalizada. Mostre como a inferência de tipo funciona com tipos mais complexos.

    
    public class Suelen
    {
        public void Suelens()
        {
        var ss = new PessoaSuuh
        {
            Nome = "Suelen",
            Idade = 22
        };
        Console.WriteLine($"O nome e: {ss.Nome} a idade e: {22}");
        }
    }

    public class PessoaSuuh
    {
        public string Nome; 
        public int Idade;
  
    }



