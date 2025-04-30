// Projeto CRUD - Clinica Multi-Profissional

using System;
//using System.Collections.Generic;

class Program
{
    //Menu Principal
    static void Main(string[] args)
    {
        Console.WriteLine("\n=== MENU PRINCIPAL ===");
        Console.WriteLine("\n1 - Cadastrar Profissional");
        Console.WriteLine("2 - Listar Profissionais");
        Console.WriteLine("3 - Atualizar profissional");
        Console.WriteLine("4 - Excluir Profissional");
        Console.WriteLine("5 - SAIR");
        Console.WriteLine("Escolha uma das opções: ");

        int escolha;
        if (!int.TryParse(Console.ReadLine(), out escolha))
        {
           Console.WriteLine("Opção Inválida!");
        }
       Console.Clear();

        while (true)
        try
        {
                if (escolha == 1)
                {
                    Console.WriteLine("\n=== Cadastrando Profissional ===\n");
                    Cadastrar();

                }
                else if (escolha == 2)
                {
                    Console.WriteLine("=== Listando Profissionais ===\n");
                    Listar();
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("=== Atualizando Profissional ===\n");
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("=== Excluindo Profissional ===\n");
                }
                else if(escolha == 5)
                {
                    Console.WriteLine("Saindo da Aplicação...");

                }else Console.WriteLine("Opção Inválida!"); break;

        }
        catch (Exception u)
        {
           Console.WriteLine("Opção Inválida!");

        }

        

    }

    //Listas

    static List<int> registros = new List<int>();
    static List<string> nomes = new List<string>();
    static List<string> especialidades = new List<string>();
    static List<string> telefones = new List<string>();

    static void Cadastrar()
    {
        Console.WriteLine("Digite o Nome:\n");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a Especialidade:\n");
        string esp = Console.ReadLine();

        Console.WriteLine("Digite o Telefone: \n");
        string tel = Console.ReadLine();

        int reg = registros.Count + 1;

        registros.Add(reg);
        nomes.Add(nome);
        especialidades.Add(esp);
        telefones.Add(tel);

        Console.WriteLine("O Profissional foi cadastrado com sucesso!");
    }

    static void Listar()
    {
        for (int i = 0; i < registros.Count; i++) 
        {
            Console.WriteLine($"Registro: {registros[i]}");
            Console.WriteLine($"Nome: {nomes[i]}");
            Console.WriteLine($"Especialidade: {especialidades[i]}");
            Console.WriteLine($"Telefone: {telefones[i]}");
            
        }
    }
}