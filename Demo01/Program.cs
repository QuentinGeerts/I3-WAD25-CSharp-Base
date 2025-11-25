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


// Interpolation de chaînes de caractères
string prenom = "Quentin";
Console.WriteLine($"Bonjour, je m'appelle {prenom}");

// 1.  Déclaration
// > Réservation d'un emplacement en mémoire
// Type nomVariable;

string nom;

// 2.  Affectation
// > Donner une valeur
// Initialisation: 1ère affectation
// nomVariable = valeur;

nom = "Geerts";

// 3.  Déclaration + initialisation

string nom1, prenom1 = "Quentin";

// 4. Portée de la variable
if (true)
{
    Console.WriteLine($"Tu t'appelles {prenom} {nom}");
    int age = 29;
    Console.WriteLine($"Tu as {age} ans.");
}
//Console.WriteLine($"Tu as {age} ans."); // Non accessible

// 5.  Constantes
// > Emplacement en mémoire immuable (contenu ne peut pas varier)
// const Type NOM_CONSTANTE = valeur;

const double PI = 3.141592;
// PI = 3.14; // Plus possible de modifier

// 6.  Nullable
// Utilisation de la classe Nullable
// Nullable<Type> nomVariable;

// null: rien informatique (absence de valeur)

// Types "Valeur": ne sont pas nullables
int a = 42;
int c = a;

//int e = null;
Nullable<int> e = null;
int? f = null; // Sucre syntaxique

Console.WriteLine($"Ref a et c : {ReferenceEquals(a, c)}"); // False

c = 42;

// Types "Référence": sont nullables
string b = "Quentin";
string d = b;

Console.WriteLine($"Ref b et d : {ReferenceEquals(b, d)}"); // True
d = "Sahar";
Console.WriteLine($"Ref b et d : {ReferenceEquals(b, d)}"); // False