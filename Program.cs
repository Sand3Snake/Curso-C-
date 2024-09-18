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
                // Título
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA                 ║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Informações do autor e data/hora
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║ Autor: Suelen Soares da Silva                                ║");
                Console.WriteLine($" ║ Data e Hora: {DateTime.Now,-44}    ║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Opções do menu
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║ 1. Gerenciar Equipamentos                                    ║");
                Console.WriteLine(" ║ 2. Gerenciar Usuários                                        ║");
                Console.WriteLine(" ║ 3. Gerenciar Locações                                        ║");
                Console.WriteLine(" ║ 4. Gerar Relatório                                           ║");
                Console.WriteLine(" ║ 0. Sair                                                      ║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Escolha da opção
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" Escolha uma opção: ");
                Console.ForegroundColor = ConsoleColor.Cyan;

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
                        case 4:
                            GerarRelatorio();
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
        static void GerarRelatorio()
        {
            Console.Clear();
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║       SISTEMA DE GERENCIAMENTO DE ACADEMIA - RELATÓRIO       ║");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Relatório de Equipamentos
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║                          Equipamentos                        ║");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");
            if (equipamentos.Count == 0)
            {
                Console.WriteLine(" Nenhum equipamento cadastrado.");
            }
            else
            {
                Console.WriteLine($" {"ID",-4} | {"Nome",-20} ");
                Console.WriteLine(new string('=', 30));
                foreach (var equipamento in equipamentos)
                {
                    Console.WriteLine($" {equipamento.Id,-4} | {equipamento.Nome,-20} ");
                }
                Console.WriteLine(new string('-', 30));
                Console.WriteLine($" Total de Equipamentos: {equipamentos.Count}");
            }

            // Relatório de Usuários
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║                            Usuários                          ║");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");
            if (usuarios.Count == 0)
            {
                Console.WriteLine(" Nenhum usuário cadastrado.");
            }
            else
            {
                Console.WriteLine($" {"ID",-4} | {"Nome",-20} ");
                Console.WriteLine(new string('=', 30));
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($" {usuario.Id,-4} | {usuario.Nome,-20} ");
                }
                Console.WriteLine(new string('-', 30));
                Console.WriteLine($" Total de Usuários: {usuarios.Count}");
            }

            // Relatório de Locações
            Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║                            Locações                          ║");
            Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");
            if (locacoes.Count == 0)
            {
                Console.WriteLine(" Nenhuma locação cadastrada.");
            }
            else
            {
                Console.WriteLine($" {"ID",-4} | {"Equipamento",-20} | {"Usuário",-20} ");
                Console.WriteLine(new string('=', 50));
                foreach (var locacao in locacoes)
                {
                    Console.WriteLine($" {locacao.Id,-4} | {locacao.Equipamento.Nome,-20} | {locacao.Usuario.Nome,-20} ");
                }
                Console.WriteLine(new string('-', 50));
                Console.WriteLine($" Total de Locações: {locacoes.Count}");
            }

            Console.ResetColor(); // Reseta a cor do console para o padrão.
        }



        static void MenuEquipamentos()
        {
            int opcao = -1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA                 ║");
                Console.WriteLine(" ║               Gerenciar Equipamentos                         ║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Informações do autor e data/hora
                string autor = "Autor: Suelen Soares da Silva";
                string dataHora = $"Data e Hora: {DateTime.Now}";
                int larguraTotal = 62; // Largura total entre as bordas
                int espacosRestantesAutor = larguraTotal - autor.Length;
                int espacosRestantesData = larguraTotal - dataHora.Length;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine($" ║{autor}{new string(' ', espacosRestantesAutor)}║");
                Console.WriteLine($" ║{dataHora}{new string(' ',espacosRestantesData)}║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Opções do menu de gerenciamento de equipamentos
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║ 1. Adicionar Equipamento                                     ║");
                Console.WriteLine(" ║ 2. Listar Equipamentos                                       ║");
                Console.WriteLine(" ║ 3. Atualizar Equipamento                                     ║");
                Console.WriteLine(" ║ 4. Remover Equipamento                                       ║");
                Console.WriteLine(" ║ 0. Voltar                                                    ║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Escolha de opção
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" Escolha uma opção: ");
                Console.ForegroundColor = ConsoleColor.Cyan;

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

                // Título do menu
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA                 ║");
                Console.WriteLine(" ║                  Gerenciar Usuários                          ║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Informações do autor e data/hora
                string autor = "Autor: Suelen Soares da Silva";
                string dataHora = $"Data e Hora: {DateTime.Now}";
                int larguraTotal = 62; // Largura total entre as bordas
                int espacosRestantesAutor = larguraTotal - autor.Length;
                int espacosRestantesData = larguraTotal - dataHora.Length;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine($" ║{autor}{new string(' ', espacosRestantesAutor)}║");
                Console.WriteLine($" ║{dataHora}{new string(' ', espacosRestantesData)}║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Opções de gerenciamento de usuários
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║ 1. Adicionar Usuário                                         ║");
                Console.WriteLine(" ║ 2. Listar Usuários                                           ║");
                Console.WriteLine(" ║ 3. Atualizar Usuário                                         ║");
                Console.WriteLine(" ║ 4. Remover Usuário                                           ║");
                Console.WriteLine(" ║ 0. Voltar                                                    ║");
                Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

                // Escolha de opção
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" Escolha uma opção: ");
                Console.ForegroundColor = ConsoleColor.Cyan;

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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
                Console.WriteLine(" ║                 gerenciar locações                    ║");
                Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
                Console.WriteLine($" Autor: Suelen Soares da Silva");
                Console.WriteLine($" Data e Hora: {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine(" ║                SELECIONE UMA OPÇÃO                    ║");
                Console.WriteLine(" ╠═══════════════════════════════════════════════════════╣");
                Console.WriteLine(" ║ 1. Adicionar Locação                                  ║");
                Console.WriteLine(" ║ 2. Listar Locações                                    ║");
                Console.WriteLine(" ║ 3. Atualizar Locação                                  ║");
                Console.WriteLine(" ║ 4. Remover Locação                                    ║");
                Console.WriteLine(" ║ 0. Voltar                                             ║");
                Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Green;
                

                Console.Write(" Escolha uma opção: ");
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
       
        static bool IsValidId(string input)
        {
            if (IsValidNumber(input))
            {
                int id = int.Parse(input);
                return id > 0;
            }
            return false;
        }

        static void AdicionarEquipamento()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                ADICIONAR NOVO EQUIPAMENTO             ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Digite o nome do equipamento: ");
            string nome = Console.ReadLine();

            if (IsValidText(nome))
            {
                int id = equipamentos.Count > 0 ? equipamentos[^1].Id + 1 : 1;
                Equipamento equipamento = new Equipamento(id, nome);
                equipamentos.Add(equipamento);

                Console.WriteLine("\n Equipamento adicionado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\n Nome do equipamento inválido. Por favor, insira um texto válido (não pode estar em branco ou conter apenas números).");
            }

            Console.ResetColor(); // Reseta a cor do console para o padrão.
        }

        static bool IsValidText(string text)
        {
            // Verifica se o texto é nulo ou vazio
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            // Verifica se o texto contém apenas números
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }

            return false;
        }




        static void ListarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                Lista de Equipamentos                  ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (equipamentos.Count == 0)
            {
                Console.WriteLine("\nNenhum equipamento cadastrado.");
            }
            else
            {
                // Cabeçalho da tabela
                Console.WriteLine(" ╔═══════╦═══════════════════════════════════════════════╗");
                Console.WriteLine(" ║   ID  ║             Nome                              ║");
                Console.WriteLine(" ╠═══════╬═══════════════════════════════════════════════╣");
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Listagem dos equipamentos
                foreach (var equipamento in equipamentos)
                {
                    Console.WriteLine($" ║ {equipamento.Id,-5} ║{equipamento.Nome,-30}                 ║");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                // Rodapé da tabela
                Console.WriteLine(" ╚═══════╩═══════════════════════════════════════════════╝");
            }

            Console.ResetColor(); // Reseta a cor do console
        }

        static void AtualizarEquipamento()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                 ATUALIZAR EQUIPAMENTO                 ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Digite o ID do equipamento a ser atualizado: ");
            string id = Console.ReadLine();

            if (IsValidId(id))
            {
                int equipamentoId = int.Parse(id);
                var equipamento = equipamentos.Find(e => e.Id == equipamentoId);

                if (equipamento != null)
                {
                    Console.Write(" Digite o novo nome do equipamento: ");
                    string nome = Console.ReadLine();

                    if (IsValidText(nome))
                    {
                        equipamento.Nome = nome;
                        Console.WriteLine("\n Equipamento atualizado com sucesso!");
                        SalvarDados();
                    }
                    else
                    {
                        Console.WriteLine("\n Nome do equipamento inválido. Por favor, insira um texto válido (não pode estar em branco ou conter apenas números).");
                    }
                }
                else
                {
                    Console.WriteLine("\n Equipamento não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\n ID do equipamento inválido. Por favor, insira um número positivo.");
            }

            Console.ResetColor();  // Reseta a cor do console para o padrão.
        }



        static void RemoverEquipamento()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                 remover equipamento                   ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Digite o ID do equipamento a ser removido: ");
            string id = Console.ReadLine();

            if (IsValidId(id))
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
                Console.WriteLine("\nID do equipamento inválido. Por favor, insira um número positivo.");
            }
        }

        static void AdicionarUsuario()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                ADICIONAR NOVO USUÁRIO                 ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Digite o nome do usuário: ");
            string nome = Console.ReadLine();

            if (IsValidText(nome))
            {
                int id = usuarios.Count > 0 ? usuarios[^1].Id + 1 : 1;
                Usuario usuario = new Usuario(id, nome);
                usuarios.Add(usuario);

                Console.WriteLine("\n Usuário adicionado com sucesso!");
                SalvarDados();
            }
            else
            {
                Console.WriteLine("\n Nome do usuário inválido. Por favor, insira um texto válido (não pode estar em branco ou conter apenas números).");
            }

            Console.ResetColor(); // Reseta a cor do console para o padrão.
        }


        static void ListarUsuarios()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                   LISTA DE USUÁRIOS                   ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (usuarios.Count == 0)
            {
                Console.WriteLine("\n Nenhum usuário cadastrado.");
            }
            else
            {
                Console.WriteLine(" ╔════════════╦══════════════════════════════════════════╗");
                Console.WriteLine(" ║ ID         ║ Nome                                     ║");
                Console.WriteLine(" ╠════════════╬══════════════════════════════════════════╣");

                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($" ║ {usuario.Id,-10} ║ {usuario.Nome,-30}           ║");
                }

                Console.WriteLine(" ╚════════════╩══════════════════════════════════════════╝");
            }

            Console.ResetColor();  // Reseta a cor do console para o padrão.
        }


        static void AtualizarUsuario()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                 ATUALIZAR USUÁRIO                     ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Digite o ID do usuário a ser atualizado: ");
            string id = Console.ReadLine();

            if (IsValidId(id))
            {
                int usuarioId = int.Parse(id);
                var usuario = usuarios.Find(u => u.Id == usuarioId);

                if (usuario != null)
                {
                    Console.Write(" Digite o novo nome do usuário: ");
                    string nome = Console.ReadLine();

                    if (IsValidText(nome))
                    {
                        usuario.Nome = nome;
                        Console.WriteLine("\n Usuário atualizado com sucesso!");
                        SalvarDados();
                    }
                    else
                    {
                        Console.WriteLine("\n Nome do usuário inválido. Por favor, insira um texto válido (não pode estar em branco ou conter apenas números).");
                    }
                }
                else
                {
                    Console.WriteLine("\n Usuário não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\n ID do usuário inválido. Por favor, insira um número positivo.");
            }

            Console.ResetColor(); // Reseta a cor do console para o padrão.
        }


        static void RemoverUsuario()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                  remover usuário                      ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Digite o ID do usuário a ser removido: ");
            string id = Console.ReadLine();

            if (IsValidId(id))
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
                Console.WriteLine("\nID do usuário inválido. Por favor, insira um número positivo.");
            }
        }

        static void AdicionarLocacao()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                ADICIONAR NOVA LOCAÇÃO                 ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Digite o ID do equipamento: ");
            string equipamentoId = Console.ReadLine();

            if (IsValidId(equipamentoId))
            {
                int idEquipamento = int.Parse(equipamentoId);
                var equipamento = equipamentos.Find(e => e.Id == idEquipamento);

                if (equipamento != null)
                {
                    Console.Write(" Digite o ID do usuário: ");
                    string usuarioId = Console.ReadLine();

                    if (IsValidId(usuarioId))
                    {
                        int idUsuario = int.Parse(usuarioId);
                        var usuario = usuarios.Find(u => u.Id == idUsuario);

                        if (usuario != null)
                        {
                            int locacaoId = locacoes.Count > 0 ? locacoes[^1].Id + 1 : 1;
                            Locacao locacao = new Locacao(locacaoId, equipamento, usuario);
                            locacoes.Add(locacao);

                            Console.WriteLine("\n Locação adicionada com sucesso!");
                            SalvarDados();
                        }
                        else
                        {
                            Console.WriteLine("\n Usuário não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n ID do usuário inválido. Por favor, insira um número positivo.");
                    }
                }
                else
                {
                    Console.WriteLine("\n Equipamento não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\n ID do equipamento inválido. Por favor, insira um número positivo.");
            }

            Console.ResetColor(); // Reseta a cor do console para o padrão.
        }


        static void ListarLocacoes()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                  lista de locações                    ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

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
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                  ATUALIZAR LOCAÇÃO                    ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Digite o ID da locação a ser atualizada: ");
            string id = Console.ReadLine();

            if (IsValidId(id))
            {
                int locacaoId = int.Parse(id);
                var locacao = locacoes.Find(l => l.Id == locacaoId);

                if (locacao != null)
                {
                    Console.Write(" Digite o novo ID do equipamento: ");
                    string equipamentoId = Console.ReadLine();

                    if (IsValidId(equipamentoId))
                    {
                        int equipamentoIdInt = int.Parse(equipamentoId);
                        var equipamento = equipamentos.Find(e => e.Id == equipamentoIdInt);

                        if (equipamento != null)
                        {
                            Console.Write(" Digite o novo ID do usuário: ");
                            string usuarioId = Console.ReadLine();

                            if (IsValidId(usuarioId))
                            {
                                int usuarioIdInt = int.Parse(usuarioId);
                                var usuario = usuarios.Find(u => u.Id == usuarioIdInt);

                                if (usuario != null)
                                {
                                    locacao.Equipamento = equipamento;
                                    locacao.Usuario = usuario;
                                    Console.WriteLine("\n Locação atualizada com sucesso!");
                                    SalvarDados();
                                }
                                else
                                {
                                    Console.WriteLine("\n Usuário não encontrado.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n ID do usuário inválido. Por favor, insira um número positivo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n Equipamento não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n ID do equipamento inválido. Por favor, insira um número positivo.");
                    }
                }
                else
                {
                    Console.WriteLine("\n Locação não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("\n ID da locação inválido. Por favor, insira um número positivo.");
            }

            Console.ResetColor(); // Reseta a cor do console para o padrão.
        }


        static void RemoverLocacao()
        {
            Console.Clear();
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║         SISTEMA DE GERENCIAMENTO DE ACADEMIA          ║");
            Console.WriteLine(" ║                  remover locação                      ║");
            Console.WriteLine(" ╚═══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(" Digite o ID da locação a ser removida: ");
            string id = Console.ReadLine();

            if (IsValidId(id))
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
                Console.WriteLine("\nID da locação inválido. Por favor, insira um número positivo.");
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