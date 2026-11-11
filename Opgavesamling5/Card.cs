using System;
using System.Collections.Generic;

namespace Opgave5_3
{
    public class Card
    {
        public string Value { get; set; }
        public string Suit { get; set; }

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Suit} {Value}";
        }

        public static void Shuffle(List<Card> cards)
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public static Card DrawCard(List<Card> cards)
        {
            if (cards.Count == 0) return null;
            Random rng = new Random();
            int index = rng.Next(cards.Count);
            Card card = cards[index];
            cards.RemoveAt(index);
            return card;
        }

        public static void DealCards(List<Card> cards, int numberOfPlayers)
        {
            List<List<Card>> players = new List<List<Card>>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new List<Card>());
            }

            for (int i = 0; i < cards.Count; i++)
            {
                players[i % numberOfPlayers].Add(cards[i]);
            }

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"\n--- Spiller {i + 1} ({players[i].Count} kort) ---");
                foreach (var c in players[i])
                {
                    Console.Write($"{c} | ");
                }
                Console.WriteLine();
            }
        }
    }
}