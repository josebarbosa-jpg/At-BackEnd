string[] vetDiaSemana = new string[]
{
    "Domingo",
    "Segunda-Feira",
    "Terça-Feira",
    "Quarta-Feira",
    "Quinta-Feira",
    "Sexta-Feira",
    "Sabado"
};

string[] vetTarefas = new string[7];

for (int i = 0; i < vetDiaSemana.Length; i++)
{
    Console.WriteLine($"Digite suas tarefas de {vetDiaSemana[i]}: ");
    vetTarefas[i] = Console.ReadLine();
}
Console.WriteLine("\n Tarefas p/ semana:");
for (int i = 0; i < vetDiaSemana.Length; i++)
{
    Console.WriteLine($"{vetDiaSemana}: {vetTarefas}");
}

Console.ReadKey();
