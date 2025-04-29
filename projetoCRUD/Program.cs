// Projeto CRUD - Clinica Multi-Profissional

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n=== MENU PRINCIPAL ===");
        Console.WriteLine("\n1 - Cadastrar Profissional");
        Console.WriteLine("2 - Listar Profissionais");
        Console.WriteLine("3 - Atualizar profissioal");
        Console.WriteLine("4 - Excluir Profissional");
        Console.WriteLine("5 - SAIR");
        Console.WriteLine("Escolha uma das opções: ");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("CADASTRANDO PROFISSIONAL");
                break;

            case 2: 
                Console.WriteLine("LISTAR PROFISSIONAIS"); 
                break;


        }



    }

}