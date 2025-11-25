/*
 * Démonstration 04 - Structures conditionnelles
 */


// 1.  if ... else if ... else ...

// 1.1.  if ...

if (true)
{
    Console.WriteLine("Exécution du bloc d'instructions");
}

if (false)
{
    Console.WriteLine($"Non exécution du bloc d'instructions");
}

// 1.2.  if ... else ...

if (true)
{
    Console.WriteLine($"Exécuté...");
}
else
{
    Console.WriteLine("Ne sera pas exécuté...");
}

// --

if (false)
{
    Console.WriteLine("Ne sera pas exécuté...");
}
else
{
    Console.WriteLine($"Exécuté...");
}

// 1.3.  Raccourci (sans accolade)

if (true) Console.WriteLine($"Code exécuté..");

if (true) 
    Console.WriteLine($"Code exécuté..");

// 1.4.  if ... else if ... else ...

if (false)
{
    Console.WriteLine($"Non exécuté");
}
else if (true)
{
    Console.WriteLine($"Exécuté");
}
else if (true)
{
    Console.WriteLine($"Exécuté");
}
else
{
    Console.WriteLine($"Non exécuté");
}


// 2.  switch ...

var jour = "mardi";

switch (jour)
{
    case "lundi":
        Console.WriteLine($"Badminton");
        break;

    case "mardi":
    case "jeudi":
        Console.WriteLine($"Jeux de société");
        break;

    case "mercredi":
        Console.WriteLine($"Lecture");
        break;

    default:
        Console.WriteLine($"Entrée incorrecte");
        break;
}