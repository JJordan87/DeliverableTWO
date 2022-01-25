using System;

namespace Deliverable2 
{
    class Buffet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome to Jon's $9.99 all-you-can-eat Buffet!");
            Console.WriteLine();
            Console.WriteLine("We have two choices of beverages. Coffee is $2.00 & water is complimentary.");
            Console.WriteLine();
            Console.WriteLine("How many people are in your group? Please, no parties of 6 or more.");
            Console.WriteLine();

            int partySize = Convert.ToInt32(Console.ReadLine());
            if (partySize > 6)
            {
                Console.WriteLine("Unfortunatly we do not have the table space for parties larger than 6. " +
                    "Please split your party up into separate groups to be seated.");
                Environment.Exit(0);
            }
            Console.WriteLine();
            Console.WriteLine($"Table for {partySize}! Please follow me and take a seat.");
            Console.WriteLine();
            Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
            Console.WriteLine();
            Console.WriteLine();

            List<string> drinks = new List<string>();
            string userResponse;
            for (int i = 0; i < partySize; i++)
            {
                    Console.WriteLine($"Alright, person number {i+1}, water or coffee?");
                    userResponse = Console.ReadLine().ToLower();
                    Console.WriteLine();

                if (userResponse == "coffee" || userResponse == "water")
                {
                    if (userResponse == "coffee")
                    {
                        drinks.Add(userResponse);
                        Console.WriteLine($"{userResponse} ,you are going to love the new dark roast.");
                    }
                    else
                    {
                        drinks.Add(userResponse);
                        Console.WriteLine($"{userResponse} ,smart choice.");
                        Console.WriteLine();
                    }
                    
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Don't order product not on the menu. NEXT!");
                    Console.WriteLine();
                }
            }
            double coffeeCount = 0;
            double waterCount = 0;
            foreach (string drink in drinks)
            {
                if (drink == "coffee")
                {
                    coffeeCount++;
                }
                else if (drink == "water")
                {
                    waterCount++;
                }
            }

            Console.WriteLine("Okay, so that's " + coffeeCount + " coffee(s) and " + waterCount + " water(s)." +
                " I'll be right back. Feel free to grab your food!");
            Console.WriteLine();
            Console.WriteLine();


            double billTotal = partySize * 9.99 + coffeeCount * 2.00;
            Console.WriteLine();
            Console.WriteLine("Here's your bill! Total price: $" + billTotal);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Receipt Breakdown");
            double buffetTotal = partySize * 9.99;
            double coffeeTotal = coffeeCount * 2.00;
            Console.WriteLine($"{partySize} buffet(s) = {partySize} x $9.99 = ${buffetTotal}");
            Console.WriteLine($"{coffeeCount} coffee(s) = {coffeeCount} x $2.00 = ${coffeeTotal}");
            Console.WriteLine($"{waterCount} water(s) = free");
            Console.WriteLine($"total = ${billTotal}");
                                  
        }
    }
}