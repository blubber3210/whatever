namespace whatever
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //GameOfLife.Run();
            //WeirdShapes.DrawSquare();
            //WeirdShapes.DrawSquareWithSmile();

            // Bossfight - får jeg ikke helt til, kommer tilbake til det
            /*
            GameCharacter Hero = new GameCharacter(100, 20, 40);
            GameCharacter Boss = new GameCharacter(400, 0 - 30, 10);

            Hero.Fight(Boss);
            */


            // Organtransplant - droppet 

            //Person bernt = new Person("Bernt", false, true);
            //Person kare = new Person("Kåre", true, true);

            //Kidney kareKidney = new Kidney(true, "Kåre");

            //kare.DonateKidney(bernt);

            //clicker experiment
            // Version 1 no class 
            /*
            Console.Write("somethign");
            int count = 0;

            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    count++;
                    Console.WriteLine($"Clicks: {count}");
                }
            }
            */

            // Version 2 with class 
            /*
            Clicker clicker = new Clicker(0);

            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    clicker.Click();
                    Console.WriteLine($"Clicks: {clicker.Count}");
                }
            }
            */

            // Version 3 - multiple clickers
            /*    
            Dictionary<ConsoleKey, Clicker> clickers = new()
            {
                { ConsoleKey.A, new Clicker(0) },
                { ConsoleKey.S, new Clicker(0) },
                { ConsoleKey.D, new Clicker(0) },
            };

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (clickers.ContainsKey(key))
                {
                    clickers[key].Click();
                    Console.WriteLine($"{key}: {clickers[key].Count}");
                }
            }
            */


        }

        

    }
}
