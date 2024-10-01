int numero;

while (true)
{
    Console.Write("Digite um número positivo: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out numero) && numero > 0)
    {
        break; // sáq é so qnd o número for válido
    }
    else
    {
        Console.WriteLine("Por favor, digite um número inteiro positivo!");
    }
}

Console.WriteLine($"Números ímpares de 1 até {numero}:");
for (int i = 1; i <= numero; i += 2)
{
    Console.WriteLine(i);
}

//encerrar
Console.WriteLine("Por favor, digite uma tecla para encerrar...");
Console.ReadKey();