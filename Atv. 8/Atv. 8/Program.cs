double celcius;

Console.Write("Informe a temperatura em celcius:");
celcius = Convert.ToDouble(Console.ReadLine());

double mult = (celcius * 9 / 5) + 32;

Console.WriteLine($"A temperatura em fahrenheit é de: {mult}");