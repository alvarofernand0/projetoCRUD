// Projeto CRUD - Clinica Multi-Profissional

using System;
using System.Collections.Generic;

// Listas para guardar os dados dos profissionais

List<int> ids = new List<int>();
List<string> nomes = new List<string>();
List<string> especialidades = new List<string>();
List<string> telefones = new List<string>();



MenuPrincipal();


//Menu Principal
void MenuPrincipal()
{
    while (true) // Esse While garante que o bloco abaixo seja
                    // executado enquanto não escolher SAIR do programa
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
        if (escolha == 1)
        {
            Cadastrar();
        }
        else if (escolha == 2)
        {
            Listar();
        }
        else if (escolha == 3)
        {
            Atualizar();
        }
        else if (escolha == 4)
        {
            Excluir();
        }
        else if (escolha == 5)
        {
            Console.Clear();
            Console.WriteLine("Saindo da Aplicação...");
            break;             // Suspende o Loop caso escolha SAIR...
        }
        else
        {
            Console.WriteLine("Escolha uma opção válida...");
        }
        Console.ReadKey();
    }
}


// Método Cadastrar
void Cadastrar()
{
    Console.Clear();
    Console.WriteLine("\n===# Menu de Cadastro #===");
    Console.Write("\nDigite o Nome do Profissional: ");
    string nome = Console.ReadLine();

    Console.WriteLine("\nDigite a Especialidade:\n");
    string especialidade = Console.ReadLine();

    Console.WriteLine("Digite o Telefone:\n");
    string telefone = Console.ReadLine();

    int id = ids.Count + 1;               // Atribui 1 cadastro(id) a cada nova interação. O id é usado para rastrear cada cadastro

    ids.Add(id);                          // Adiciona o que está na variável 'id' à lista 'ids'
    nomes.Add(nome);                      // Adiciona o que está na variável 'nome' à lista 'nomes'
    especialidades.Add(especialidade);    // Adiciona o que está na variável 'especialidade' à lista 'especialidades'
    telefones.Add(telefone);              // Adiciona o que está na variável 'telefone' à lista 'telefones'

    Console.Clear();
    Console.WriteLine("\nCadastro Concluído!\n" +
    "Tecle |C| para novo Cadastro ou |Enter| para voltar ao Menu");

    while(true)                                     //Roda o bloco em Loop
    {
        var tecla = Console.ReadKey(true).Key;      //Guarda a tecla pressionada

        if (tecla == ConsoleKey.C)                  //Pede para teclar 'C'
        {
            Cadastrar();                            //Chama o menu de cadastro
        }
        else if (tecla == ConsoleKey.Enter)         //Pede para teclar 'Enter'
        {
            MenuPrincipal();                        //Chama o menu principal
            break;
        }
        else 
        {
            Console.WriteLine("Opção inválida!");
        }
    }
}

// Método Listar
void Listar()
{
    Console.Clear();
    Console.WriteLine("\n===# Menu de Listagem #===\n");

    if (ids.Count < 1)                  // Caso a Lista de ids não tenha ao menos um id cadastrado retorna uma mensagem
    {
        Console.WriteLine("Não há Profissionais Listados...");
    }

    for (int i = 0; i < ids.Count; i++)         // Percorre do 1° indice até o ultimo que tenha um cadastro
    {
        Console.WriteLine("\n------------------------\n");      // O bloco exibe id, nome, espec e tel de cada cadastro
        Console.WriteLine($"id: {ids[i]}\n");
        Console.WriteLine($"Nome: {nomes[i]}\n");
        Console.WriteLine($"Especialidade: {especialidades[i]}\n");
        Console.WriteLine($"Telefone: {telefones[i]}");
        Console.WriteLine("\n------------------------\n");

    }
}

// Método Atualizar
void Atualizar()
{
    Console.Clear();
    Console.WriteLine("\n===# Menu de Atualização #===\n");

    for (int i = 0; i < ids.Count; i++) 
    {
        Console.WriteLine($"\nid: {i + 1}\nNome: {nomes[i]}");
    }

    Console.WriteLine("Digite o id do profissional que deseja atualizar");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int indiceLista) && indiceLista >= 1 && indiceLista <= ids.Count) 
    {
        int idNovo = indiceLista;

        Console.WriteLine("\nDigite o novo Nome");
        string nomeNovo = Console.ReadLine();

        Console.WriteLine("\nDigite a nova Especialidade");
        string especNova = Console.ReadLine();

        Console.WriteLine("\nDigite o novo Telefone");
        string telNovo = Console.ReadLine();

        ids[indiceLista - 1] = idNovo;
        nomes[indiceLista - 1] = nomeNovo;
        especialidades[indiceLista - 1] = especNova;
        telefones[indiceLista - 1] = telNovo;
    }
    else if (ids.Count < 1)
    {
        Console.WriteLine("Não há profissionais para atualizar...");
        return;
    }
}

// Método Excluir
void Excluir()
{
    Console.Clear();
    Console.WriteLine("\n===# Menu de Exclusão #===\n");

    if (ids.Count == 0)
    {
        Console.WriteLine("\nNão há Profissionais para Excluir...");
        return;
    }

    Console.WriteLine("\nDigite o id do Profissional que deseja Excluir");

    if (int.TryParse(Console.ReadLine(), out int id))
    {

    }
    else
    {
        Console.WriteLine("\nEscolha uma opção válida");
    }

    bool encontrado = false;

    for (int i = 0; i < ids.Count; i++)
    {
        if (ids[i] == id)
        {
            ids.RemoveAt(i);
            nomes.RemoveAt(i);
            especialidades.RemoveAt(i);

            Console.WriteLine("Profissional Removido!");
            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Profissional não Encontrado...");
    }

}

