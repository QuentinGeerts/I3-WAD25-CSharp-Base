// See https://aka.ms/new-console-template for more information
Console.InputEncoding = System.Text.Encoding.Unicode;   
//Configure notre console pour lire les caractères Unicode tels les smileys
Console.OutputEncoding = System.Text.Encoding.Unicode;  
//Configure notre console pour afficher les caractères Unicode tels les smileys

Console.Clear();

Console.WriteLine("Hello, je m'appelle {0} !", "Samuel");
Console.WriteLine("Pouvez-vous me donner votre nom :");
string? username = Console.ReadLine();
Console.Clear();
Console.WriteLine("Bienvenue {0} au cours de C# !", username);
Console.WriteLine();
Console.Write("Notre première utilisation de Visual Studio");
Console.WriteLine(" est un succès !");

Console.WriteLine("Pour quitter le programme, appuyez sur n'importe quelle touche...");
Console.ReadKey(true);  // true pour ne pas afficher le caractère dans la console
Console.Clear();
