int numero;
Console.WriteLine("Digite um número positivo: ");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i} X {numero} = {i * numero}");
}