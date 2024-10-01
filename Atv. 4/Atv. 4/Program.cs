double PI = 3.14159;
double n1;

Console.Write("Informe o Raio:");
n1 = Convert.ToDouble(Console.ReadLine());

double multiplicacao = n1 * n1;
double multi = multiplicacao * PI;
Console.WriteLine($"A área do circulo condiz com: {multi}");