namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1() {
            Console.Write("Add meg, mennyien értékelték összesen a játékot: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Add meg, hányan értékelték pozitívan a játékot: ");
            int p = int.Parse(Console.ReadLine());

            double positivePercentage = ((double)p / n) * 100;
            int roundedPercentage = (int)Math.Round(positivePercentage);

            string evaluation;
            ConsoleColor color;

            if (roundedPercentage > 90)
            {
                evaluation = "Nagyon pozitív";
                color = ConsoleColor.Green;
            }
            else if (roundedPercentage >= 75)
            {
                evaluation = "Pozitív";
                color = ConsoleColor.Green;
            }
            else if (roundedPercentage >= 55)
            {
                evaluation = "Többnyire pozitív";
                color = ConsoleColor.Green;
            }
            else if (roundedPercentage >= 45)
            {
                evaluation = "Vegyes";
                color = ConsoleColor.Yellow;
            }
            else if (roundedPercentage >= 25)
            {
                evaluation = "Többnyire negatív";
                color = ConsoleColor.Red;
            }
            else if (roundedPercentage >= 10)
            {
                evaluation = "Negatív";
                color = ConsoleColor.Red;
            }
            else
            {
                evaluation = "Nagyon negatív";
                color = ConsoleColor.Red;
            }

            Console.ForegroundColor = color;
            Console.WriteLine($"A játék értékelése: {evaluation} ({roundedPercentage}%)");
            Console.ResetColor();
        }

        static void feladat2() { }

        static void feladat3() { }

        static void feladat4() { }

        static void Main(string[] args)
        {   
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            feladat1();
        }
    }
}
