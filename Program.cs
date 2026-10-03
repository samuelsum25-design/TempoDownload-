Console.WriteLine("--- Tempo de Downlooad ---");
Console.WriteLine("Tamanho do arquino em MB........: ");
double tamanho = double.Parse(Console.ReadLine()) * 8; // Convertendo de MB (1 byte = 8 bits)
Console.WriteLine("Velocidade da conexão em Mbps...: ");
double velocidade = double.Parse(Console.ReadLine());
double tempo = (tamanho / velocidade) / 60; // Convertendo de segundos para minutos
Console.WriteLine($"Tempo de download: {tempo:F2} minutos");


