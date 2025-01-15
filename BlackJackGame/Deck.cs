using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace BlackJackGame
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    cards.Add(new Card(rank, suit));
                }
            }
        }

        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("No cards left in the deck.");
            }
            Card cardToDeal = cards[0];
            cards.RemoveAt(0); // Remove the top card from the deck
            return cardToDeal;
        }

        public void ResetDeck()
        {
            cards.Clear();
            InitializeDeck();
            Shuffle();
        }

        public int CardsRemaining()
        {
            return cards.Count;
        }
    }
}