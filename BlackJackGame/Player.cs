using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; private set; } 
        public int Score { get; private set; } 
        public bool IsBusted { get; private set; } 
        public bool IsStanding { get; set; } 

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
            Score = 0;
            IsBusted = false;
            IsStanding = false;
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
            UpdateScore(card);  // Update score after adding a card
        }

        // Modified UpdateScore method
        private void UpdateScore(Card newCard = null)
        {
            Score = 0;
            int aceCount = 0;

            foreach (var card in Hand)
            {
                if (card.Rank == "Ace")
                {
                    aceCount++;
                    
                    if (newCard != null && newCard.Rank == "Ace" && aceCount == 1 && Name == "Player")
                    {
                        Score += GetAceValue(); 
                    }
                    else
                    {
                        Score += 11;
                    }
                }
                else if (card.Rank == "2" || card.Rank == "3" || card.Rank == "4" || card.Rank == "5" ||
                         card.Rank == "6" || card.Rank == "7" || card.Rank == "8" || card.Rank == "9" || card.Rank == "10")
                {
                    Score += int.Parse(card.Rank);
                }
                else
                {
                    Score += 10; // Face cards (Jack, Queen, King) are worth 10 points
                }
            }

            // Check if the player is busted
            if (Score > 21)
            {
                IsBusted = true;
            }
        }
        private int GetAceValue()
        {
            using (var aceForm = new AceVal())
            {
                // Show the form and wait for selection
                if (aceForm.ShowDialog() == DialogResult.OK)
                {
                    return aceForm.AceValue; 
                }
            }

            // Default value
            return 11;  
        }

        public void ResetHand()
        {
            Hand.Clear();
            Score = 0;
            IsBusted = false;
            IsStanding = false;
        }

        public override string ToString()
        {
            return $"{Name}: {Score} points";
        }
    }
}
