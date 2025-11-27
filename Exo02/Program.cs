// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez introduire un nombre");
string input = Console.ReadLine()!;
int nombre;
bool isConverted = int.TryParse(input, out nombre);
if (isConverted)
{
    int div = nombre / 2;

    if (div + div == nombre)
    {
        Console.WriteLine($"Le nombre {nombre} est pair");
    }
    else
    {
        Console.WriteLine($"Le nombre {nombre} est impair");
    }
}
else {
    Console.WriteLine($"La valeur \"{input}\" n'est pas un nombre...");
}

/*int nombre = int.Parse(input);
int div = nombre / 2;

if(div + div == nombre)
{
    Console.WriteLine("Le nombre est pair");
}
else
{
    Console.WriteLine("Le nombre est impair");
}*/