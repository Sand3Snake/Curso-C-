using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SistemaGerenciamentoAcademia
{
    class Program
    {
        static List<Equipamento> equipamentos = new List<Equipamento>();
        static List<Usuario> usuarios = new List<Usuario>();
        static List<Locacao> locacoes = new List<Locacao>();

        static string caminhoEquipamentos = @"C:\Users\Aluno Noite\Documents\Curso-C-\equipamentos.json";
        static string caminhoUsuarios = @"C:\Users\Aluno Noite\Documents\Curso-C-\usuarios.json";
        static string caminhoLocacoes = @"C:\Users\Aluno Noite\Documents\Curso-C-\locacoes.json";

        static void Main(string[] args)
        {
            CarregarDados();
            int opcao = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==== Sistema de Gerenciamento de Academia ====");
                Console.WriteLine("==============================================");
                Console.WriteLine("Autor: Suelen Soares da Silva");
                Console.WriteLine($"Data e Hora: {DateTime.Now}");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Gerenciar Equipamentos");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("3. Gerenciar Locações");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            MenuEquipamentos();
                            break;
                        case 2:
                            MenuUsuarios();
                            break;
                        case 3:
                            MenuLocacoes();
                            break;
                        case 0:
                            SalvarDados();
                            Console.WriteLine("\nSaindo do programa...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número.");
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuEquipamentos()
        {
            int opcao = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==== Sistema de Gerenciamento de Academia ====");
                Console.WriteLine("====         Gerenciar Equipamentos       ====");
                Console.WriteLine("==============================================");
                Console.WriteLine($"Autor: Suelen Soares da Silva");
                Console.WriteLine($"Data e Hora: {DateTime.Now}");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Equipamento");
                Console.WriteLine("2. Listar Equipamentos");
                Console.WriteLine("3. Atualizar Equipamento");
                Console.WriteLine("4. Remover Equipamento");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarEquipamento();
                            break;
                        case 2:
                            ListarEquipamentos();
                            break;
                        case 3:
                            AtualizarEquipamento();
                            break;
                        case 4:
                            RemoverEquipamento();
                            break;
                        case 0:
                            Console.WriteLine("\nVoltando ao menu principal...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número.");
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuUsuarios()
        {
            int opcao = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==== Sistema de Gerenciamento de Academia ====");
                Console.WriteLine("====         Gerenciar Usuários           ====");
                Console.WriteLine("==============================================");
                Console.WriteLine($"Autor: Suelen Soares da Silva");
                Console.WriteLine($"Data e Hora: {DateTime.Now}");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Usuário");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Atualizar Usuário");
                Console.WriteLine("4. Remover Usuário");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarUsuario();
                            break;
                        case 2:
                            ListarUsuarios();
                            break;
                        case 3:
                            AtualizarUsuario();
                            break;
                        case 4:
                            RemoverUsuario();
                            break;
                        case 0:
                            Console.WriteLine("\nVoltando ao menu principal...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número.");
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuLocacoes()
        {
            int opcao = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==== Sistema de Gerenciamento de Academia ====");
                Console.WriteLine("====          Gerenciar Locações          ====");
                Console.WriteLine("==============================================");
                Console.WriteLine($"Autor: Suelen Soares da Silva");
                Console.WriteLine($"Data e Hora: {DateTime.Now}");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Locação");
                Console.WriteLine("2. Listar Locações");
                Console.WriteLine("3. Atualizar Locação");
                Console.WriteLine("4. Remover Locação");
                Console.WriteLine("0. Voltar");

                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarLocacao();
                            break;
                        case 2:
                            ListarLocacoes();
                            break;
                        case 3:
                            AtualizarLocacao();
                            break;
                        case 4:
                            RemoverLocacao();
                            break;
                        case 0:
                            Console.WriteLine("\nVoltando ao menu principal...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, insira um número.");
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static bool IsValidNumber(string input)
        {
            return int.TryParse(input, out _);
        }

        static bool IsValidText(string input)
        {
            return !int.TryParse(input, out _);
        }

        static void AdicionarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("======    adicionar novo equipamento   ========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();

            if (IsValidText(nome))
            {
                int id = equipamentos.Count > 0 ? equipamentos[^1].Id + 1 : 1;
                Equipamento equipamento = new Equipamento(id, nome);
                equipamentos.Add(equipamento);

                Console.WriteLine("\nEquipamento adicionado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nNome do equipamento inválido. Por favor, insira um texto.");
            }
        }

        static void ListarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("==========    lista de equipamentos     ========");
            Console.WriteLine("==============================================");

            if (equipamentos.Count == 0)
            {
                Console.WriteLine("\nNenhum equipamento cadastrado.");
            }
            else
            {
                foreach (var equipamento in equipamentos)
                {
                    Console.WriteLine($"ID: {equipamento.Id} - Nome: {equipamento.Nome}");
                }
            }
        }

        static void AtualizarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("=========  atualizar equipamento  ================");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do equipamento a ser atualizado: ");
            string id = Console.ReadLine();

            if (IsValidNumber(id))
            {
                int equipamentoId = int.Parse(id);
                var equipamento = equipamentos.Find(e => e.Id == equipamentoId);

                if (equipamento != null)
                {
                    Console.Write("Digite o novo nome do equipamento: ");
                    string nome = Console.ReadLine();

                    if (IsValidText(nome))
                    {
                        equipamento.Nome = nome;
                        Console.WriteLine("\nEquipamento atualizado com sucesso!");
                        SalvarDados();
                    }
                    else
                    {
                        Console.WriteLine("\nNome do equipamento inválido. Por favor, insira um texto.");
                    }
                }
                else
                {
                    Console.WriteLine("\nEquipamento não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do equipamento inválido. Por favor, insira um número.");
            }
        }

        static void RemoverEquipamento()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("==========    remover equipamento     ============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do equipamento a ser removido: ");
            string id = Console.ReadLine();

            if (IsValidNumber(id))
            {
                int equipamentoId = int.Parse(id);
                var equipamento = equipamentos.Find(e => e.Id == equipamentoId);

                if (equipamento != null)
                {
                    equipamentos.Remove(equipamento);
                    Console.WriteLine("\nEquipamento removido com sucesso!");
                    SalvarDados();
                }
                else
                {
                    Console.WriteLine("\nEquipamento não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do equipamento inválido. Por favor, insira um número.");
            }
        }

        static void AdicionarUsuario()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("======    adicionar novo usuário    ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            if (IsValidText(nome))
            {
                int id = usuarios.Count > 0 ? usuarios[^1].Id + 1 : 1;
                Usuario usuario = new Usuario(id, nome);
                usuarios.Add(usuario);

                Console.WriteLine("\nUsuário adicionado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\nNome do usuário inválido. Por favor, insira um texto.");
            }
        }

        static void ListarUsuarios()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("==========     lista de usuários      ========");
            Console.WriteLine("==============================================");

            if (usuarios.Count == 0)
            {
                Console.WriteLine("\nNenhum usuário cadastrado.");
            }
            else
            {
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($"ID: {usuario.Id} - Nome: {usuario.Nome}");
                }
            }
        }

        static void AtualizarUsuario()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("=========  atualizar usuário  ================");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do usuário a ser atualizado: ");
            string id = Console.ReadLine();

            if (IsValidNumber(id))
            {
                int usuarioId = int.Parse(id);
                var usuario = usuarios.Find(u => u.Id == usuarioId);

                if (usuario != null)
                {
                    Console.Write("Digite o novo nome do usuário: ");
                    string nome = Console.ReadLine();

                    if (IsValidText(nome))
                    {
                        usuario.Nome = nome;
                        Console.WriteLine("\nUsuário atualizado com sucesso!");
                        SalvarDados();
                    }
                    else
                    {
                        Console.WriteLine("\nNome do usuário inválido. Por favor, insira um texto.");
                    }
                }
                else
                {
                    Console.WriteLine("\nUsuário não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do usuário inválido. Por favor, insira um número.");
            }
        }

        static void RemoverUsuario()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("==========    remover usuário     ============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID do usuário a ser removido: ");
            string id = Console.ReadLine();

            if (IsValidNumber(id))
            {
                int usuarioId = int.Parse(id);
                var usuario = usuarios.Find(u => u.Id == usuarioId);

                if (usuario != null)
                {
                    usuarios.Remove(usuario);
                    Console.WriteLine("\nUsuário removido com sucesso!");
                    SalvarDados();
                }
                else
                {
                    Console.WriteLine("\nUsuário não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do usuário inválido. Por favor, insira um número.");
            }
        }

        static void AdicionarLocacao()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("======    adicionar nova locação    ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o ID do equipamento: ");
            string equipamentoId = Console.ReadLine();

            if (IsValidNumber(equipamentoId))
            {
                int id = int.Parse(equipamentoId);
                var equipamento = equipamentos.Find(e => e.Id == id);

                if (equipamento != null)
                {
                    Console.Write("Digite o ID do usuário: ");
                    string usuarioId = Console.ReadLine();

                    if (IsValidNumber(usuarioId))
                    {
                        int usuarioIdInt = int.Parse(usuarioId);
                        var usuario = usuarios.Find(u => u.Id == usuarioIdInt);

                        if (usuario != null)
                        {
                            int locacaoId = locacoes.Count > 0 ? locacoes[^1].Id + 1 : 1;
                            Locacao locacao = new Locacao(locacaoId, equipamento, usuario);
                            locacoes.Add(locacao);

                            Console.WriteLine("\nLocação adicionada com sucesso!");
                            SalvarDados();
                        }
                        else
                        {
                            Console.WriteLine("\nUsuário não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nID do usuário inválido. Por favor, insira um número.");
                    }
                }
                else
                {
                    Console.WriteLine("\nEquipamento não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do equipamento inválido. Por favor, insira um número.");
            }
        }

        static void ListarLocacoes()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("==========     lista de locações    ==========");
            Console.WriteLine("==============================================");

            if (locacoes.Count == 0)
            {
                Console.WriteLine("\nNenhuma locação cadastrada.");
            }
            else
            {
                foreach (var locacao in locacoes)
                {
                    Console.WriteLine($"ID: {locacao.Id} - Equipamento: {locacao.Equipamento.Nome} - Usuário: {locacao.Usuario.Nome}");
                }
            }
        }

        static void AtualizarLocacao()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("=========  atualizar locação  ================");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID da locação a ser atualizada: ");
            string id = Console.ReadLine();

            if (IsValidNumber(id))
            {
                int locacaoId = int.Parse(id);
                var locacao = locacoes.Find(l => l.Id == locacaoId);

                if (locacao != null)
                {
                    Console.Write("Digite o novo ID do equipamento: ");
                    string equipamentoId = Console.ReadLine();

                    if (IsValidNumber(equipamentoId))
                    {
                        int equipamentoIdInt = int.Parse(equipamentoId);
                        var equipamento = equipamentos.Find(e => e.Id == equipamentoIdInt);

                        if (equipamento != null)
                        {
                            Console.Write("Digite o novo ID do usuário: ");
                            string usuarioId = Console.ReadLine();

                            if (IsValidNumber(usuarioId))
                            {
                                int usuarioIdInt = int.Parse(usuarioId);
                                var usuario = usuarios.Find(u => u.Id == usuarioIdInt);

                                if (usuario != null)
                                {
                                    locacao.Equipamento = equipamento;
                                    locacao.Usuario = usuario;
                                    Console.WriteLine("\nLocação atualizada com sucesso!");
                                    SalvarDados();
                                }
                                else
                                {
                                    Console.WriteLine("\nUsuário não encontrado.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nID do usuário inválido. Por favor, insira um número.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nEquipamento não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nID do equipamento inválido. Por favor, insira um número.");
                    }
                }
                else
                {
                    Console.WriteLine("\nLocação não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("\nID da locação inválido. Por favor, insira um número.");
            }
        }

        static void RemoverLocacao()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==== SISTEMA DE GERENCIAMENTO DE ACADEMIA ====");
            Console.WriteLine("==========    remover locação     ============");
            Console.WriteLine("==============================================");

            Console.Write("Digite o ID da locação a ser removida: ");
            string id = Console.ReadLine();

            if (IsValidNumber(id))
            {
                int locacaoId = int.Parse(id);
                var locacao = locacoes.Find(l => l.Id == locacaoId);

                if (locacao != null)
                {
                    locacoes.Remove(locacao);
                    Console.WriteLine("\nLocação removida com sucesso!");
                    SalvarDados();
                }
                else
                {
                    Console.WriteLine("\nLocação não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("\nID da locação inválido. Por favor, insira um número.");
            }
        }

        static void SalvarDados()
        {
            File.WriteAllText(caminhoEquipamentos, JsonSerializer.Serialize(equipamentos));
            File.WriteAllText(caminhoUsuarios, JsonSerializer.Serialize(usuarios));
            File.WriteAllText(caminhoLocacoes, JsonSerializer.Serialize(locacoes));
        }

        static void CarregarDados()
        {
            if (File.Exists(caminhoEquipamentos))
            {
                string json = File.ReadAllText(caminhoEquipamentos);
                equipamentos = JsonSerializer.Deserialize<List<Equipamento>>(json) ?? new List<Equipamento>();
            }

            if (File.Exists(caminhoUsuarios))
            {
                string json = File.ReadAllText(caminhoUsuarios);
                usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
            }

            if (File.Exists(caminhoLocacoes))
            {
                string json = File.ReadAllText(caminhoLocacoes);
                locacoes = JsonSerializer.Deserialize<List<Locacao>>(json) ?? new List<Locacao>();
            }
        }
    }

    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Equipamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    public class Locacao
    {
        public int Id { get; set; }
        public Equipamento Equipamento { get; set; }
        public Usuario Usuario { get; set; }

        public Locacao(int id, Equipamento equipamento, Usuario usuario)
        {
            Id = id;
            Equipamento = equipamento;
            Usuario = usuario;
        }
    }
}