// See https://aka.ms/new-console-template for more information
//Níivel 1: Variáveis e Operações Básicas
#region 1. Calculadora de média
Console.WriteLine("Digite a primeira nota:");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());

decimal media = nota1 + nota2 + nota3 / 3;

Console.WriteLine($"A sua média é: {media}.");
#endregion

#region 2. Conversor de Idade
#endregion