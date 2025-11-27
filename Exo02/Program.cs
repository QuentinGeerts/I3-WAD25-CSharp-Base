// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez introduire un nombre");
string input = Console.ReadLine()!;
int nombre = int.Parse(input);
int div = nombre / 2;

if(div + div == nombre)
{
    Console.WriteLine("Le nombre est pair");
}
else
{
    Console.WriteLine("Le nombre est impair");
}