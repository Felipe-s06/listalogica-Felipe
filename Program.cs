// See https://aka.ms/new-console-template for more information
//Níivel 1: Variáveis e Operações Básicas
#region 1. Calculadora de média
//Console.Write("Digite a primeira nota: ");
//decimal nota1 = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Digite a segunda nota: ");
//decimal nota2 = Convert.ToDecimal(Console.ReadLine());
//Console.Write("Digite a terceira nota: ");
//decimal nota3 = Convert.ToDecimal(Console.ReadLine());

//decimal media = nota1 + nota2 + nota3 / 3;

//Console.WriteLine($"A sua média é: {media:F2}.");
#endregion

#region 2. Conversor de Idade
//Console.Write($"Digite sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//int conversaoIdade = idade * 365;

//Console.WriteLine($"\nVocê tem {conversaoIdade} dias.");
#endregion

#region 3. Troca de Valores
//int Numero1 = 10;
//int Numero2 = 16;
//Console.WriteLine($"O primeiro número é {Numero1} e o segundo número é {Numero2}.\n");

//Console.Write($"Digite 'Trocar' para fazer as trocas do números: ");
//string Verificacao = Console.ReadLine();


//if (Verificacao.ToLower() == "trocar")
//{
//    int Numero3 = Numero1;
//    Numero1 = Numero2;
//    Numero2 = Numero3;
//    Console.WriteLine($"\nSucesso na troca!\n Agora o primeiro número é {Numero1} e o segundo número é {Numero2}.");

//}
//else
//{
//    Console.WriteLine("\nFalha!\nA troca não foi feita.");
//}
#endregion

#region 4. Verificador de Maioridade
//Console.Write("Digite sua idade:");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine("Entrada autorizada.");
//}
//else
//{
//    Console.WriteLine("Entrada não autorizada.");
//}
#endregion

#region 5. Classificador de Número
//Console.Write("Digite um núemro para classificação: ");
//int Numero = Convert.ToInt32(Console.ReadLine());

//if (Numero % 2 == 0 && Numero >= 0)
//{
//    Console.WriteLine($"{Numero} é Par e Positivo");
//}
//else if (Numero % 2 != 0 && Numero >= 0)
//{
//    Console.WriteLine($"{Numero} é Ímpar e Positivo.");
//}
//else
//{
//    Console.WriteLine($"{Numero} é Negativo.");
//}

#endregion

#region 6. Validação de Login Simples 
//string usuario_correto = "admin";
//string senha_correta = "12345";

//Console.Write("Digite o nome de usuário: ");
//string usuario_input = Console.ReadLine();

//Console.Write("Digite a senha: ");
//string senha_input = Console.ReadLine();

//if (usuario_input == usuario_correto && senha_input == senha_correta)
//{
//    Console.WriteLine("Login efetuado com sucesso!");
//}
//else
//{
//    Console.WriteLine("Usuário ou senha inválidos.");
//}
#endregion

#region 7. Contagem Regressiva 
//for (int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Lançar!");
#endregion

#region 8. Soma de Ímpares
//int soma = 0;
//int numero;

//Console.WriteLine("Digite números (0 para parar):");

//while (true)
//{
//    numero = int.Parse(Console.ReadLine());

//    if (numero == 0) break; 

//    if (numero % 2 != 0)
//    {
//        soma += numero;
//    }
//}

//Console.WriteLine($"A soma total dos números ímpares é: {soma}");
#endregion

#region 9. Tabuada Personalizada
//Console.Write("Digite um número inteiro para ver a tabuada: ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{n} x {i} = {n * i}");
//}
#endregion

#region 10. Inversão de Array
//string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };

//Console.WriteLine("Lista Original (usando for):");

//for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine(nomes[i]);
//}

//Console.WriteLine("\nLista Invertida (usando for):");

//for (int i = nomes.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(nomes[i]);
//}
#endregion

#region 11. Busca e Contagem em Lista
//List<string> cores = new List<string> { "Azul", "Vermelho", "Azul", "Verde", "Amarelo", "Azul", "Verde" };

//Console.Write("Digite uma cor para buscar: ");
//string busca = Console.ReadLine();

//int contador = 0;

//foreach (string cor in cores)
//{
    
//    if (cor.Equals(busca, StringComparison.OrdinalIgnoreCase))
//    {
//        contador++;
//    }
//}

//Console.WriteLine($"A cor '{busca}' aparece {contador} vezes na lista.");
#endregion

#region 12. Gerenciador de Tarefas Simples
List<string> tarefas = new List<string>();
string opcao = "";

// Loop para manter o programa em execução até que o usuário escolha "3" (Sair)
while (opcao != "3")
{
    // Exibição do Menu
    Console.WriteLine("\n--- GERENCIADOR DE TAREFAS ---");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Listar Tarefas");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma opção: ");

    opcao = Console.ReadLine();

    // Switch para tratar as opções do menu
    switch (opcao)
    {
        case "1":
            Console.Write("Digite a descrição da tarefa: ");
            string novaTarefa = Console.ReadLine();
            tarefas.Add(novaTarefa); // Adiciona na lista
            Console.WriteLine("Tarefa adicionada com sucesso!");
            break;

        case "2":
            Console.WriteLine("\n--- LISTA DE TAREFAS ---");
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                // Usando o loop for (sem foreach) para listar
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i]}");
                }
            }
            break;

        case "3":
            Console.WriteLine("Encerrando o programa...");
            break;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
}
#endregion