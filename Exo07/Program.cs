namespace Exo07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number;
            bool isConverted;
            string message = "Veuillez saisir un nombre entier positif pour calculer son factoriel : ";

            do
            {
                Console.WriteLine(message);
                message = "Entrée invalide. Veuillez saisir un nombre entier positif : ";
                isConverted = uint.TryParse(Console.ReadLine()!, out number);
            }
            while (!isConverted || number <= 0);

            ulong resultat = 1;

            for (uint i = 1; i <= number; i++) {
                Console.Write($"{resultat} * {i} = ");
                resultat *= i;
                Console.WriteLine(resultat);
            }
            Console.WriteLine($"Le factoriel de {number} est {resultat}.");
        }
    }
}
