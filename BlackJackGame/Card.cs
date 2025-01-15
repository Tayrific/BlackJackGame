using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public class Card
    {
        //originally used before i switched to using images only!
        public string Rank { get; set; } 
        public string Suit { get; set; } 
        public string FileName => $"{Rank}_{Suit}"; 

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
