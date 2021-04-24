using System;

namespace สอบปฎิบัติครั้งที่1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number =int.Parse(Console.ReadLine());
            while(Number < 1 || Number > 7)
            {
                Console.Write("reagain");
                int.Parse(Console.ReadLine());
            }
            float Time = float.Parse(Console.ReadLine());
            while (Time < 8 || Time > 18) 
            {
                Console.Write("reagain");
                int.Parse(Console.ReadLine());
            }
             string food = Console.ReadLine();
            switch (food)
            {
                case ("Breakfast Set"):
                    while (Time < 8 || Time > 12)
                        {
                        Console.Write("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                    break;
                case ("Weekend Set"):

                    break;
                case ("Coffee"):

                    break;
                case ("End"):                    
                    break;

            }
        }
    }
}
