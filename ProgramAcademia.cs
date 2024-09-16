using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaAcademia
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.Json;

    namespace SistemaAcademia
    {
        // Classe Equipamento
        public class Equipamento
        {
            public string Nome { get; set; }
            public string Tipo { get; set; }

            public Equipamento() { } // Construtor padrão necessário para deserialização

            public Equipamento(string nome, string tipo)
            {
                Nome = nome;
                Tipo = tipo;
            }

            public void ExibirDetalhes()
            {
                Console.WriteLine($"Nome: {Nome}, Tipo: {Tipo}");
            }
        }

        // Classe Academia
        public class Academia
        {
            private List<Equipamento> acervo = new List<Equipamento>();

            public void AdicionarEquipamento(Equipamento equipamento)
            {
                acervo.Add(equipamento);
            }

            public void RemoverEquipamento(Equipamento equipamento)
            {
                acervo.Remove(equipamento);
            }

            public Equipamento BuscarEquipamentoPorNome(string nome)
            {
                return acervo.FirstOrDefault(equipamento => equipamento.Nome == nome);
            }

            public List<Equipamento> ObterEquipamentos()
            {
                return new List<Equipamento>(acervo);
            }
        }

        // Classe Usuario
        public class Usuario
        {
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public List<Equipamento> EquipamentosLocados { get; set; } = new List<Equipamento>();

            public Usuario() { } // Construtor padrão necessário para deserialização

            public Usuario(string nome, string cpf)
            {
                Nome = nome;
                Cpf = cpf;
            }

            public void LocarEquipamento(Equipamento equipamento, Academia academia)
            {
                Equipamento equipamentoLocado = academia.BuscarEquipamentoPorNome(equipamento.Nome);
                if (equipamentoLocado != null)
                {
                    EquipamentosLocados.Add(equipamentoLocado);
                    academia.RemoverEquipamento(equipamentoLocado);
                    Console.WriteLine($"{Nome} locou o equipamento '{equipamento.Nome}'.");
                }
            }

            public void DevolverEquipamento(Equipamento equipamento, Academia academia)
            {
                if (EquipamentosLocados.Contains(equipamento))
                {
                    EquipamentosLocados.Remove(equipamento);
                    academia.AdicionarEquipamento(equipamento);
                    Console.WriteLine($"{Nome} devolveu o equipamento '{equipamento.Nome}'.");
                }
            }

            public void ExibirEquipamentosLocados()
            {
                Console.WriteLine($"Equipamentos locados por {Nome}:");
                foreach (var equipamento in EquipamentosLocados)
                {
                    equipamento.ExibirDetalhes();
                }
            }
        }

        // Classe Locacao
        public class Locacao
        {
            public string UsuarioCpf { get; set; }
            public string EquipamentoNome { get; set; }
            public DateTime DataLocacao { get; set; }
        }

        // Classe Dados para deserialização
        public class Dados
        {
            public List<Usuario> Usuarios { get; set; }
            public List<Equipamento> Equipamentos { get; set; }
            public List<Locacao> Locacoes { get; set; }
        }
    }
}
