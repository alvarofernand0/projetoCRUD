// Projeto CRUD - Clinica Multi-Profissional

using System;
//using System.Collections.Generic;

class Program
{
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

                }
                else if (escolha == 2)
                {
                    Console.WriteLine("=== Listando Profissionais ===\n");
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
    static List<int> Id = new List<int>();
    static List<string> Nome = new List<string>();
    static List<string> Especialidade = new List<string>();
    static List<int> Telefone = new List<int>();
}