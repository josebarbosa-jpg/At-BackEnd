
string nome;
string sobrenome;
string programação;

//Perguntado os valores
Console.Write("Informe o seu nome:");
nome = Console.ReadLine(); //Ler uma linha e armazena seu valor

//Console.WriteLine($"\nSeu nome é: {nome}");

Console.Write("\nInforme a seu sobrenome:");
sobrenome = Console.ReadLine();

Console.Write("\nInforme a sua área favorita de programação:");
programação = Console.ReadLine();


Console.WriteLine($"Seu nome completo é {nome} {sobrenome}, e sua área favorita de programação é {programação}.");
