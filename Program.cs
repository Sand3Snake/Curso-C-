using SistemaAcademia.SistemaAcademia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Curso_C_
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static Biblioteca academia = new Biblioteca();
        static List<Locacao> locacoes = new List<Locacao>();

        static void Main(string[] args)
        {
            CarregarDados();

            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        GerenciarBiblioteca();
                        break;
                    case "2":
                        GerenciarUsuarios();
                        break;
                    case "0":
                        SalvarDados();
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void GerenciarBiblioteca()
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR BIBLIOTECA   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Listar Livros");
                Console.WriteLine("2. Adicionar Livro");
                Console.WriteLine("3. Remover Livro");
                Console.WriteLine("4. Emprestar Livro");
                Console.WriteLine("5. Devolver Livro");
                Console.WriteLine("0. Voltar ao Menu Principal");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ListarLivros();
                        break;
                    case "2":
                        AdicionarLivro();
                        break;
                    case "3":
                        RemoverLivro();
                        break;
                    case "4":
                        EmprestarLivro();
                        break;
                    case "5":
                        DevolverLivro();
                        break;
                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void GerenciarUsuarios()
        {
            bool voltar = false;
            while (!voltar)
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=========   GERENCIAR USUÁRIOS   =========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Listar Usuários");
                Console.WriteLine("2. Adicionar Usuário");
                Console.WriteLine("3. Remover Usuário");
                Console.WriteLine("4. Listar Livros Emprestados por Usuário");
                Console.WriteLine("0. Voltar ao Menu Principal");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ListarUsuarios();
                        break;
                    case "2":
                        AdicionarUsuario();
                        break;
                    case "3":
                        RemoverUsuario();
                        break;
                    case "4":
                        ListarLivrosEmprestadosPorUsuario();
                        break;
                    case "0":
                        voltar = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void ListarLivros()
        {
            // Implementar o método para listar livros da biblioteca
        }

        static void AdicionarLivro()
        {
            // Implementar o método para adicionar livro à biblioteca
        }

        static void RemoverLivro()
        {
            // Implementar o método para remover livro da biblioteca
        }

        static void EmprestarLivro()
        {
            // Implementar o método para emprestar livro
        }

        static void DevolverLivro()
        {
            // Implementar o método para devolver livro
        }

        static void ListarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Documents\Curso-C-\usuarios.json";

            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    string json = File.ReadAllText(caminhoArquivo);
                    var dados = JsonSerializer.Deserialize<Dados>(json);

                    if (dados != null && dados.Usuarios != null)
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine("=========   LISTA DE USUÁRIOS CADASTRADOS   =========");
                        Console.WriteLine("==============================================");

                        if (dados.Usuarios.Count == 0)
                        {
                            Console.WriteLine("\nNenhum usuário cadastrado.");
                        }
                        else
                        {
                            for (int i = 0; i < dados.Usuarios.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {dados.Usuarios[i].Nome} - CPF: {dados.Usuarios[i].Cpf}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos ou a lista de usuários está vazia.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar ou desserializar o JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void ListarEquipamentos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Documents\Curso-C-\equipamentos.json";

            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    string json = File.ReadAllText(caminhoArquivo);
                    var dados = JsonSerializer.Deserialize<Dados>(json);

                    if (dados != null && dados.Equipamentos != null)
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine("=========   LISTA DE EQUIPAMENTOS CADASTRADOS   =========");
                        Console.WriteLine("==============================================");

                        if (dados.Equipamentos.Count == 0)
                        {
                            Console.WriteLine("\nNenhum equipamento cadastrado.");
                        }
                        else
                        {
                            for (int i = 0; i < dados.Equipamentos.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {dados.Equipamentos[i].Nome} - Tipo: {dados.Equipamentos[i].Tipo}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos ou a lista de equipamentos está vazia.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar ou desserializar o JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void ListarLocacoes()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Documents\Curso-C-\locacoes.json";

            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    string json = File.ReadAllText(caminhoArquivo);
                    var dados = JsonSerializer.Deserialize<Dados>(json);

                    if (dados != null && dados.Locacoes != null)
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine("=========   LISTA DE LOCAÇÕES CADASTRADAS   =========");
                        Console.WriteLine("==============================================");

                        if (dados.Locacoes.Count == 0)
                        {
                            Console.WriteLine("\nNenhuma locação cadastrada.");
                        }
                        else
                        {
                            for (int i = 0; i < dados.Locacoes.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. Usuário CPF: {dados.Locacoes[i].UsuarioCpf} - Equipamento: {dados.Locacoes[i].EquipamentoNome} - Data: {dados.Locacoes[i].DataLocacao}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos ou a lista de locações está vazia.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar ou desserializar o JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void ListarLivrosEmprestadosPorUsuario()
        {
            // Implementar o método para listar livros emprestados por um usuário específico
        }

        static void AdicionarUsuario()
        {
            // Implementar o método para adicionar um novo usuário
        }

        static void RemoverUsuario()
        {
            // Implementar o método para remover um usuário
        }

        static void CarregarDados()
        {
            string caminhoUsuarios = @"C:\Users\Aluno Noite\Documents\Curso-C-\usuarios.json";
            if (File.Exists(caminhoUsuarios))
            {
                try
                {
                    string json = File.ReadAllText(caminhoUsuarios);
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null && dados.Usuarios != null)
                    {
                        usuarios = dados.Usuarios;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar dados dos usuários: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo de usuários não encontrado.");
            }

            // Carregar Equipamentos e Locações também
        }

        static void SalvarDados()
        {
            string caminhoUsuarios = @"C:\Users\Aluno Noite\Documents\Curso-C-\usuarios.json";
            string caminhoEquipamentos = @"C:\Users\Aluno Noite\Documents\Curso-C-\equipamentos.json";
            string caminhoLocacoes = @"C:\Users\Aluno Noite\Documents\Curso-C-\locacoes.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = usuarios,
                    // Preencher com a lista de equipamentos e locações
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoUsuarios, json);
                // Salvar os arquivos de equipamentos e locações
                Console.WriteLine("Dados salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar dados: {ex.Message}");
            }
        }
    }
}
