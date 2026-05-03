Console.Write("Enter your name: ");
string? input = Console.ReadLine();
string name = string.IsNullOrWhiteSpace(input) ? "World" : input;
Console.WriteLine($"Hello, {name}!");
