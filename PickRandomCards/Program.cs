using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of cards to choose from: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                

                foreach (string card in CarkPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
                Console.ReadLine();
                               
            }
            else
            {
                Console.WriteLine("Please enter a valid number buddy!");
            }
        }
    }
}
