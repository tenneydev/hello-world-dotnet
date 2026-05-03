var greetings = new Dictionary<string, string>
{
    { "English",    "Hello" },
    { "Spanish",    "Hola" },
    { "French",     "Bonjour" },
    { "German",     "Hallo" },
    { "Japanese",   "こんにちは" },
    { "Mandarin",   "你好" },
    { "Arabic",     "مرحبا" },
    { "Portuguese", "Olá" },
};

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Select a language:");
Console.ResetColor();

int i = 1;
foreach (var lang in greetings.Keys)
    Console.WriteLine($"  {i++}. {lang}");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("\nChoice (1-{0}): ", greetings.Count);
Console.ResetColor();

string? choiceInput = Console.ReadLine();
bool valid = int.TryParse(choiceInput, out int index) && index >= 1 && index <= greetings.Count;

if (!valid)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(!int.TryParse(choiceInput, out _)
        ? $"Invalid input — defaulting to English."
        : $"Choice must be between 1 and {greetings.Count} — defaulting to English.");
    Console.ResetColor();
}

string language = valid ? greetings.Keys.ElementAt(index - 1) : "English";
string greeting = greetings[language];

string name  = Prompt("Enter your name: ",            "World");
string color = Prompt("What is your favorite color? ", "unknown");
string mood  = Prompt("How are you feeling today? ",   "unspecified");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n{greeting}, {name}!");
Console.WriteLine($"Your favorite color is {color} and you're feeling {mood} today.");
Console.ResetColor();

static string Prompt(string prompt, string fallback)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(prompt);
    Console.ResetColor();
    string? input = Console.ReadLine();
    return string.IsNullOrWhiteSpace(input) ? fallback : input;
}
