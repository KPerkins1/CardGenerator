using System;
using System.Collections.Generic;

namespace CardGenerator
{
    public class Card
    {
        public string cardSuit { get; set; }
        public int cardRank { get; set; }
        public string ImageUrl
        {
            get
            {
                string rankCode = cardRank switch
                {
                    1 => "A",
                    10 => "0",
                    11 => "J",
                    12 => "Q",
                    13 => "K",
                    _ => cardRank.ToString()
                };

                string suitCode = cardSuit switch
                {
                    "Spades" => "S",
                    "Hearts" => "H",
                    "Diamonds" => "D",
                    "Clubs" => "C",
                    _ => throw new InvalidOperationException($"Unknown card suit: {cardSuit}")
                };

                return $"https://deckofcardsapi.com/static/img/{rankCode}{suitCode}.png";
            }
        }

        public Card(string suit, int rank)
        {
            this.cardRank = rank;
            this.cardSuit = suit;
        }

        public static Card RandomCard()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            int[] ranks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Random randy = new Random();
            
            string randomSuit = suits[randy.Next(suits.Length)];

            int randomRank = ranks[randy.Next(ranks.Length)];

            return new Card(randomSuit, randomRank);
        }
    }
}
