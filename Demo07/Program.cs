namespace Demo07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number;
            string input;
            do
            {
                Console.Write("Veuillez introduire un nombre (entre 1 et 100): ");
                input = Console.ReadLine()!;                
            }
            while (!int.TryParse(input, out number) || number < 1 || number > 100);


            bool isPerfectSquare = false;

            /* VERSION FOR 
            for (int i = 1; i <= 10 && !isPerfectSquare; i++)
            {
                if (i * i == number)
                {
                    isPerfectSquare = true;
                }
            }*/

            /* VERSION WHILE */

            int i = 1;

            while (i <= 10 && !isPerfectSquare)
            {
                if (i * i == number)
                {
                    isPerfectSquare = true;
                }
                i++;
            }

            if (isPerfectSquare)
            {
                Console.WriteLine($"Le nombre {number} est un carré parfait.");
            }
            else
            {
                Console.WriteLine($"Le nombre {number} n'est pas un carré parfait.");
            }

        }
    }
}
