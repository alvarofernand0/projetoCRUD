
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
   {            // executado enquanto não escolher SAIR do programa

      Console.Clear();
      Console.WriteLine("\n=== MENU PRINCIPAL ===\n\n");
      Console.WriteLine("1 - Cadastrar Profissional\n");
      Console.WriteLine("2 - Listar Profissionais\n");
      Console.WriteLine("3 - Atualizar profissional\n");
      Console.WriteLine("4 - Excluir Profissional\n");
      Console.WriteLine("5 - SAIR\n");
      Console.WriteLine("Escolha uma das opções...\n");
      
      int escolha;
      if (!int.TryParse(Console.ReadLine(), out escolha))
      {
         Console.WriteLine("Esta não é uma opção válida!");
      }
      else if (escolha == 1)
      {
          Cadastrar();
          Console.ReadKey();
      }
      else if (escolha == 2)
      {
          Listar();
          Console.ReadKey();
      }
      else if (escolha == 3)
      {
          Atualizar();
          Console.ReadKey();
      }
      else if (escolha == 4)
      {
          Excluir();
          Console.ReadKey();
      }
      else if (escolha == 5)
      {
          Console.Clear();
          Console.WriteLine("Saindo da Aplicação...");
          break;             // Suspende o Loop caso escolha SAIR...
      }
      else
      {
          Console.WriteLine("Você só pode escolher uma das opções!");  
      }   
   }
}

// Método Cadastrar
void Cadastrar()
{
    Console.Clear();
    Console.WriteLine("\n===# Menu de Cadastro #===\n");
    Console.Write("Digite o Nome do Profissional: ");
    string nome = Console.ReadLine();

    Console.Write("\nDigite a Especialidade: ");
    string especialidade = Console.ReadLine();

    Console.Write("\nDigite o Telefone: ");
    string telefone = Console.ReadLine();

    int id = ids.Count + 1;               // Atribui 1 cadastro(id) a cada nova interação. O id é usado para rastrear um cadastro

    ids.Add(id);                          // Adiciona o que está na variável 'id' à lista 'ids'
    nomes.Add(nome);                      // Adiciona o que está na variável 'nome' à lista 'nomes'
    especialidades.Add(especialidade);    // Adiciona o que está na variável 'especialidade' à lista 'especialidades'
    telefones.Add(telefone);              // Adiciona o que está na variável 'telefone' à lista 'telefones'

    Console.Clear();
    Console.WriteLine("\nCadastro Concluído!\n");
}

// Método Listar
void Listar()
{
    Console.Clear();
    Console.WriteLine("\n===# Menu de Listagem #===\n");

    if (ids.Count < 1)          // Caso a Lista de ids esteja vazia, retorna uma mensagem
    {
        Console.WriteLine("Não há Profissionais Listados...");
        return;
    }
    else
    {
        Console.WriteLine("\n------------------------\n");

        for (int i = 0; i < ids.Count; i++)         // Percorre do 1° indice até o ultimo que tenha um cadastro
        {
            Console.WriteLine($"id: {ids[i]}\n");   // O bloco exibe id, nome, espec e tel de cada cadastro
            Console.WriteLine($"Nome: {nomes[i]}\n");
            Console.WriteLine($"Especialidade: {especialidades[i]}\n");
            Console.WriteLine($"Telefone: {telefones[i]}");
            Console.WriteLine("\n------------------------\n");

        }
    }
}

// Método Atualizar
void Atualizar()
{
    Console.Clear();
    Console.WriteLine("\n===# Menu de Atualização #===\n");

    if (ids.Count < 1)       // Caso a Lista de ids esteja vazia, retorna uma mensagem
    {
        Console.WriteLine("Não há profissionais para atualizar...");
        return;
    }

    while (true)
    {
        Console.Write("Digite o id do profissional que deseja atualizar: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int idxLista) && idxLista >= 1 && idxLista <= ids.Count) // Tenta converter em int, se conseguir
        {                                                                                      // Guarda em idxLista, Checa se é >=1.
            Console.WriteLine("\nId encontrado! Prosseguindo...\n");                           // Checa se não passa do Tamanho
                                                                                               // da lista (<=ids.Count)
            Console.Write("Digite o novo Nome: ");
            string nomeNovo = Console.ReadLine();

            Console.Write("\nDigite a nova Especialidade: ");
            string especNova = Console.ReadLine();

            Console.Write("\nDigite o novo Telefone: ");
            string telNovo = Console.ReadLine();

            nomes[idxLista - 1] = nomeNovo;              // Substitui o que está na posição pelo novo valor
            especialidades[idxLista - 1] = especNova;
            telefones[idxLista - 1] = telNovo;

            Console.Clear();
            Console.WriteLine("\nProfissional Atualizado!");
            break;   
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\nId não encontrado!\n");
        }  
    }                                                                                         
}

// Método Excluir
void Excluir()
{
    Console.Clear();
    Console.WriteLine("\n===# Menu de Exclusão #===\n");

    if (ids.Count == 0)
    {
        Console.WriteLine("Não há Profissionais para Excluir...");
        return;
    }

    /* Usei uma variável de controle para conseguir sair do while,
       caso contrário, sairia apenas do for e continuaria o loop infinitamente*/

    bool sair = false;
    while (!sair)
    {
        Console.Write("Digite o id do Profissional que deseja Excluir: ");
        string entrada = Console.ReadLine();

        /* If principal converte para int, Verifica se existe na lista o ID que foi digitado;
        Caso algo falhe, cai no else.*/
        if (int.TryParse(entrada, out int id) && ids.Contains(id))
        {
            Console.Clear();
            Console.WriteLine("\nId Encontrado!");

            for (int i = 0; i < ids.Count; i++) // Percorre a lista ids do início ao fim, enquanto i for menor que o n° total de itens da lista
            {
                if (ids[i] == id) // Verifica se o id atual é IGUAL ao id que quer excluir
                {
                    ids.RemoveAt(i);           // Remove o item de cada lista naquele indice
                    nomes.RemoveAt(i);
                    especialidades.RemoveAt(i);
                    telefones.RemoveAt(i);

                    Console.WriteLine("\nProfissional Removido!\n");
                    sair = true;
                    break;
                }
            }
        }
        else 
        {
            Console.WriteLine("\nOpção errada ou Id inválido!\n");
        }
    }
}

//void Verificacao()
//{
    
//    Console.WriteLine("\nDeseja realmente continuar? [Digite SIM ou NAO]");
//    string verificar = Console.ReadLine();
  
//    {
//        Console.WriteLine("Digite SIM ou NAO!");
//    }
//    else
//    {
//        Console.WriteLine();
//    }
//}
