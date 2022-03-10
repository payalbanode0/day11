using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class InitialDeck
    {
        //Declaring static variables
        public static String[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };

        public static String[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        public static int totalCards = suit.Length * ranks.Length;
        public static String[] deck = new String[totalCards];
        //Method to initialize deck
        public static void InitializeDeck()
        {
            Console.WriteLine("***************DISPLAYING DECK BEFORE SHUFFLE***************");
            for (int i = 0; i < ranks.Length; i++)
            {
                for (int j = 0; j < suit.Length; j++)
                {
                    deck[4 * i + j] = ranks[i] + " of " + suit[j];
                    Console.WriteLine(deck[4 * i + j]);
                }
            }
        }
        public static void Main(string[] args)
        {
            //
            //Method call to initialize a deck
            InitializeDeck();
            //Method to shuffle and distribute cards
            ShuffleDeck.ShufflingDeck();
            //Create players object
            Players.MaintainPlayers();

        }

    }
}
