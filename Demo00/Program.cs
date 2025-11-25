namespace Demo00
{
    internal class Program
    {
        const string prenom = "Quentin";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!", args);
            Console.WriteLine(prenom);
        }

        static void Methode2 ()
        {
            //Console.WriteLine(args); // Non accessible
        }

    }
}
