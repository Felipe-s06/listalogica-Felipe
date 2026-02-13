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
//Console.WriteLine($"O primeiro número é {Numero1} e o segundo núemro é {Numero2}.\n");

//Console.Write($"Digite 'Troca' para fazer as trocas do números: ");
//Console.ReadLine();
//int Numero3 = Numero1;
//Numero1 = Numero2;
//Numero2 = Numero3;

//Console.WriteLine($"\nAgora o primeiro número é {Numero1} e o segundo núemro é {Numero2}.");

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
Console.Write("Digite um núemro para classificação: ");
int Numero = Convert.ToInt32(Console.ReadLine());

if (Numero % 2 == 0 && Numero >= 0)
{
    Console.WriteLine($"{Numero} é Par e Positivo");
}
else if (Numero % 2 != 0 && Numero >= 0)
{
    Console.WriteLine($"{Numero} é Ímpar e Positivo.");
}
else
{
    Console.WriteLine($"{Numero} é Negativo.");
}

#endregion