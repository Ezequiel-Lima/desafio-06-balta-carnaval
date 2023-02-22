using Desafio;

Console.WriteLine("Informe o texto: ");
string texto = Console.ReadLine();

Console.WriteLine(Criptografia.EncriptarTexto(texto));
Console.WriteLine(Criptografia.DescriptarTexto(texto));