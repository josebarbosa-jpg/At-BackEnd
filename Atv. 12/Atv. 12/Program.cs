double nota;
Console.Write("Informe sua nota: ");
double.TryParse(Console.ReadLine(), out nota);

if ( nota >= 90 && nota <= 100)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você tirou A!");
}
else if (nota >= 80 && nota <= 89)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Você tirou B!");
}
else if (nota >= 79 && nota <= 79)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Você tirou C!");
}
else if (nota >= 60 && nota <= 69)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você tirou D!");
}
else if (nota >= 60)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Você tirou F!");
}
else
{
    Console.WriteLine("Número invalido.");
}