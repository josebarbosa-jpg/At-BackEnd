int numero;
string mensagem = "oii, boa sorte!";
int soma = 2 + 2;

do
{
    Console.Write("Digite um número entre 1 e 3: ");
    numero = int.Parse(Console.ReadLine());
    if (numero == 1)
    {
        Console.WriteLine("" + mensagem);
    }
    else if (numero == 2)
    {
        Console.WriteLine($"2 + 2 = " + soma);
    }
} while (numero != 3);

Console.WriteLine("Programa encerrado.");
Console.ReadKey();
