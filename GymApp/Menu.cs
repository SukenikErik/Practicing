using System;

namespace GymApp
{
    public class Menu
    {
        private readonly GymService gym = new();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n1. Registration for new member.");
                Console.WriteLine("2. Purchase ossasions");
                Console.WriteLine("3. Enter the gym");
                Console.WriteLine("4. Exit the gym");
                Console.WriteLine("5. Checking the current status");
                Console.WriteLine("6. Exit from program");
                Console.Write("Choose: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": gym.Registration(); break;
                    case "2": gym.PurchaseOccasion(); break;
                    case "3": gym.Enter(); break;
                    case "4": gym.Exit(); break;
                    case "5": gym.Status(); break;
                    case "6": return;
                    default: Console.WriteLine("Invalid input. Choose a number based on what you intend to do."); break;
                }
            }
        }
    }
}
