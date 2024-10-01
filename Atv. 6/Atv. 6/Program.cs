double salario;

Console.Write("Insira seu salario:");
salario = Convert.ToDouble(Console.ReadLine());

double porcentagem;

Console.Write("Insira o percentual:");
porcentagem = Convert.ToDouble(Console.ReadLine());

double multi = porcentagem / 100;
double multip = multi * salario;
double multipli = multip + salario;

Console.WriteLine($"O salario com aumento é de: {multipli}");