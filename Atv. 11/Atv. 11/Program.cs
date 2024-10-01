try
{
    Console.Write("Digite o primeiro número: "); 
   int numero1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero1 + numero2;
    Console.WriteLine($"O resultado da som é: {resultado}");
} 
catch(FormatException)
{
    Console.WriteLine("Erro: Por favor, digite números válidos");
}
