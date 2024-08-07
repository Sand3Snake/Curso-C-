using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public class ExercicioTiposPrimitivos
    {
        // Modifique o método Ler Armazenar para armazenar o sobrenome do usuário e exibi-lo junto com o nome:
        /**public static void LerArmazenar()
        {
            string? nome;
            string? sobrenome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o sobrenome e{sobrenome}");


        // Peça ao usuário para inserir a idade e exiba o nome e a idade

            string? nome;
            int? idade;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O nome e: {nome} e a idade e{idade}");

        
        // Peça ao usuário para inserir a cidade e exiba o nome e a cidade
           
            string? cidade;

            Console.WriteLine("Digite sua cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome da cidade e: {cidade}");


         // Armazene o nome do usuário em maiúsculas e exiba-o

            string? nome;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine().ToUpper();

            Console.WriteLine($"O nome e: {nome}");

        // Armazene o nome do usuário em minúsculas e exiba-o

            string? nome;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine().ToLower();

            Console.WriteLine($"O nome e: {nome}");

        //  Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma única linha:

            string? nome;
            int? idade;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nome} {idade}");

        //  Peça ao usuário para inserir seu nome e cidade de nascimento, depois exiba ambos:

            string? nome;
            string? cidade;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e a cidade de nascimento e {cidade}");

        //  Peça ao usuário para inserir seu nome e profissão, depois exiba ambos:

            string? nome;
            string? profissao;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua profissao:");
            profissao = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e a profissao e {profissao}");

         //  Peça ao usuário para inserir seu nome e país de origem, depois exiba ambos:

            string? nome;
            string? pais;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu pais de origem:");
            pais = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o pais de origem e {pais}");

        // Peça ao usuário para inserir seu nome e número favorito, depois exiba ambos:

            string? nome;
            int? numero;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu numero favorito:");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O nome e: {nome} e o numero favorito e {numero}");

        //Peça ao usuário para inserir seu nome e hobby favorito, depois exiba ambos:

            string? nome;
            string? hobby;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu hobby:");
            hobby = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o hobby e {hobby}");

        
        //Peça ao usuário para inserir seu nome e cor favorita, depois exiba ambos:

            string? nome;
            string? cor;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a cor:");
            cor = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e a cor favorita e {cor}");

        // Peça ao usuário para inserir seu nome e filme favorito, depois exiba ambos:

            string? nome;
            string? filme;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o filme:");
            filme = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o filme favorito e {filme}");

        //  Peça ao usuário para inserir seu nome e gênero musical favorito, depois exiba ambos:

            string? nome;
            string? genero;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o genero musical:");
            genero = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o genero musical favorito e {genero}");

         //  Peça ao usuário para inserir seu nome e animal favorito, depois exiba ambos:

            string? nome;
            string? animal;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do animal:");
            animal = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o animal favorito e {animal}");

        //  Peça ao usuário para inserir seu nome e esporte favorito, depois exiba ambos:

            string? nome;
            string? esporte;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do esporte:");
            esporte = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o esporte favorito e {esporte}");

        //  Peça ao usuário para inserir seu nome e comida favorita, depois exiba ambos:

            string? nome;
            string? comida;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome da comida:");
            comida = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e a comida favorita e {comida}");

        //  Peça ao usuário para inserir seu nome e banda favorita, depois exiba ambos:

            string? nome;
            string? banda;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome da banda:");
            banda = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e a banda favorita e {banda}");

        //  Peça ao usuário para inserir seu nome e livro favorito, depois exiba ambos:

            string? nome;
            string? livro;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do livro:");
            livro = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o livro favorito e {livro}");

        // Peça ao usuário para inserir seu nome e um lema de vida, depois exiba ambos:

            string? nome;
            string? lema;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite um lema de vida:");
            lema = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome} e o lema de vida e {lema}");

        }
        */
        
        
    }
}
