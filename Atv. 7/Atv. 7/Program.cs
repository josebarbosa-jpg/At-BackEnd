double n1;
double n2;
double n3;

Console.Write("Informe sua primeira Nota:");
n1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe sua segunda Nota:");
n2 = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe sua segunda Nota:");
n3 = Convert.ToInt16(Console.ReadLine());

double multi = n1 + n2 + n3;
double divisão = multi /3;

Console.WriteLine($"A média aritimetica dos valores é de: {divisão}");
