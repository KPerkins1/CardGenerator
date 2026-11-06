using System; 
using System.Diagnostics;


namespace CardGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Card randomCard = Card.RandomCard();
            Console.WriteLine($"Random Card: {randomCard.cardRank} of {randomCard.cardSuit}");

            // After generating randomCard:
            Process.Start(new ProcessStartInfo(randomCard.ImageUrl)
            {
                UseShellExecute = true
            });
        }
    }
}