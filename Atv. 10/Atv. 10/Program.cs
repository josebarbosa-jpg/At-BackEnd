Console.Write("Escolha um npumero entre 1 e 12: ");
int numeroMes = int.Parse(Console.ReadLine());
switch (numeroMes)
{
    case 1:
        Console.WriteLine($"Você escolheu o mês de Janeiro, e a estação é verão:");
        break;
    case 2:
        Console.WriteLine($"Você escolheu o mês de Fevereiro, e a estação é verão:");
        break;
    case 3:
        Console.WriteLine($"Você escolheu o mês de Março, e a estação é outono:");
        break;
    case 4:
        Console.WriteLine($"Você escolheu o mês de Abril, e a estação é outuno:");
        break;
    case 5:
        Console.WriteLine($"Você escolheu o mês de Maio, e a estação é outuno:");
        break;
    case 6:
        Console.WriteLine($"Você escolheu o mês de Junho, e a estação é inverno:");
        break;
    case 7:
        Console.WriteLine($"Você escolheu o mês de Julho, e a estação é inverno:");
        break;
    case 8:
        Console.WriteLine($"Você escolheu o mês de Agosto, e a estação é inverno:");
        break;
    case 9:
        Console.WriteLine($"Você escolheu o mês de Setembro, e a estação é primavera:");
        break;
    case 10:
        Console.WriteLine($"Você escolheu o mês de Outubro, e a estação é primavera:");
        break;
    case 11:
        Console.WriteLine($"Você escolheu o mês de Novembro, e a estação é primavera:");
        break;
    case 12:
        Console.WriteLine($"Você escolheu o mês de Dezembro, e a estação é verão:");
        break;
}
