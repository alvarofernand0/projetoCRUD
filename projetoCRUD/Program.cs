// Projeto CRUD - Clinica Multi-Profissional

using System;
//using System.Collections.Generic;

class Program
{
    //Menu Principal
    static void Main(string[] args)
    {
        while (true) // Esse While garante que o bloco abaixo seja
                     // executado enquanto não escolher sair do programa
        {
            Console.Clear();
            Console.WriteLine("\n=== MENU PRINCIPAL ===\n\n");
            Console.WriteLine("1 - Cadastrar Profissional\n");
            Console.WriteLine("2 - Listar Profissionais\n");
            Console.WriteLine("3 - Atualizar profissional\n");
            Console.WriteLine("4 - Excluir Profissional\n");
            Console.WriteLine("5 - SAIR\n");
            Console.WriteLine("Escolha uma das opções...");

            int escolha;
            if (int.TryParse(Console.ReadLine(), out escolha)) // Caso a conversão retorne False(0)
                                                               // Solicita para digitar opçao válida
            {

            }

            if (escolha == 1)
            {
                Console.WriteLine("\n===# Cadastrando Profissional #===\n");
                Cadastrar();
            }
            else if (escolha == 2)
            {
                Console.WriteLine("===# Listando Profissionais #===\n");
                Listar();
            }
            else if (escolha == 3)
            {
                Console.WriteLine("===# Atualizando Profissional #===\n");
                Atualizar();
            }
            else if (escolha == 4)
            {
                Console.WriteLine("===# Excluindo Profissional #===\n");
            }
            else if (escolha == 5)
            {
                Console.Clear();
                Console.WriteLine("Saindo da Aplicação...");
                break; // Para a execução caso escolha sair...
            }
            else
            {
                Console.WriteLine("Escolha uma opção válida...");
            };
            Console.ReadKey();
        }
    }


    // Lista para guardar os dados dos profissionais

    static List<int> registros = new List<int>();
    static List<string> nomes = new List<string>();
    static List<string> especialidades = new List<string>();
    static List<string> telefones = new List<string>();

    static void Cadastrar()
    {
        Console.Clear();
        Console.WriteLine("\n===# Cadastro de Profissional #===");
        Console.WriteLine("\nDigite o Nome:\n");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a Especialidade:\n");
        string especialidade = Console.ReadLine();

        Console.WriteLine("Digite o Telefone:\n");
        string telefone = Console.ReadLine();

        int registro = registros.Count + 1;

        registros.Add(registro);
        nomes.Add(nome);
        especialidades.Add(especialidade);
        telefones.Add(telefone);

        Console.Clear();
        Console.WriteLine("\nCadastro Concluído!\nTecle |C| para novo Cadastro ou |Enter| para voltar ao Menu");

        if (Console.ReadKey(true).Key == ConsoleKey.C)
        {
            Cadastrar();
        }


    }

    static void Listar()
    {
        Console.Clear();
        Console.WriteLine("\n===# Listagem de Profissionais #===");

        for (int i = 0; i < registros.Count; i++)
        {
            Console.WriteLine($"\n------------------------\nRegistro: {registros[i]}\n");
            Console.WriteLine($"Nome: {nomes[i]}\n");
            Console.WriteLine($"Especialidade: {especialidades[i]}\n");
            Console.WriteLine($"Telefone: {telefones[i]}\n------------------------");

        }
    }

    static void Atualizar()
    {
        Console.Clear();
        Console.WriteLine("\n===# Atualização de Profissional #===\n");

        if (registros.Count == 0)
        {
            Console.WriteLine("Não há profissionais cadastrados...");
            return;
        }

        for (int i = 0; i < registros.Count; i++) 
        {
            Console.WriteLine($"{i + 1}. {registros[i]}");
        }

        Console.WriteLine("Digite o Registro do profissional que deseja atualizar");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int indiceLista) && indiceLista >= 1 && indiceLista <= registros.Count) 
        {
            Console.WriteLine("\nDigite o novo Nome");
            string nomeNovo = Console.ReadLine();

            Console.WriteLine("\nDigite a nova Especialidade");
            string especNova = Console.ReadLine();

            Console.WriteLine("\nDigite o novo Telefone");
            string telNovo = Console.ReadLine();

            nomes[indiceLista - 1] = nomeNovo;
            especialidades[indiceLista - 1] = especNova;
            telefones[indiceLista - 1] = telNovo;
        }
    }
}

