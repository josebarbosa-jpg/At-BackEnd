double n1, n2;
double soma;
double subtracao;
double multi;
double divisao;

Console.Write("Informe o primeiro número:");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o segudo número:");
n2 = Convert.ToDouble(Console.ReadLine());

soma = n1 + n2;
Console.WriteLine($"A soma dos valores é: {soma}");

subtracao = n1 - n2;
Console.WriteLine($"O valor da subtração é de: {subtracao}");

multi = n1 * n2;
Console.WriteLine($"O valor da multiplicação é de: {multi}");

divisao = n1 / n2;
Console.WriteLine($"O valor da divisão é de: {divisao}");