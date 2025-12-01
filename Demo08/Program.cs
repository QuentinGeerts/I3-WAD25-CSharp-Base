namespace Demo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] jourSemaine = {    //indices
                "Lundi",                //0
                "Mardi",                //1
                "Mercredi",             //2
                "Jeudi",                //3
                "Vendredi",             //4
                "Samedi",               //5
                "Dimanche" };           //6

            string[] mois = new string[12];

            mois[0] = "Janvier";
            mois[1] = "Février";
            mois[2] = "Mars";
            mois[3] = "Avril";
            mois[4] = "Mai";
            mois[5] = "Juin";
            mois[6] = "Juillet";
            mois[7] = "Août";
            mois[8] = "Septembre";
            mois[9] = "Octobre";
            mois[10] = "Novembre";
            mois[11] = "Décembre";

            string[] students;

            Console.WriteLine("Veuillez indiquer le nombre d'étudiant :");
            int nbStudents = int.Parse(Console.ReadLine());

            students = new string[nbStudents];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Veuillez indiquer le nom de l'élève :");
                students[i] = Console.ReadLine();
            }

            foreach (string stud in students)
            {
                Console.WriteLine(stud);
                //stud = "Jhon";        //Depuis le .net6.0 plus possible de changer la variable
            }

            string[,] jourSemaineMulti = {                      //Indice axe principal
                {                                               //0
                                        //Indice axe secondaire
                    "Lundi",            //0
                    "Mardi",            //1
                    "Mercredi",         //2
                    "Jeudi",            //3
                    "Vendredi",         //4
                    "Samedi",           //5
                    "Dimanche"          //6
                },
                {                                               //1
                    "Maandag",          //0
                    "Dinsdag",          //1
                    "Woensdag",         //2
                    "Donderdag",        //3
                    "Vrijdag",          //4
                    "Zaterdag",         //5
                    "Zondag"            //6
                }};

            Console.WriteLine($"En néerlandais, le jour de {jourSemaineMulti[0,2]} se dit {jourSemaineMulti[1,2]}");

            double[][] pointStudents = new double[nbStudents][];

            pointStudents[0] = new double[3];
            pointStudents[0][0] = 12.4;
            pointStudents[0][1] = 13.5;
            pointStudents[0][2] = 20D;

            pointStudents[1] = null;

            pointStudents[2] = new double[]{ 15.4, 14.6 };
        }
    }
}
