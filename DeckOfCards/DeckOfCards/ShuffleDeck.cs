using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class ShuffleDeck : InitialDeck
    {
        public static void ShufflingDeck()
        {
            //Shuffling deck based on Random method
            int i;
            Random random = new Random();
            for (i = 0; i < totalCards; i++)
            {
                int temp = random.Next(0, totalCards);
                deck = SwapCharacters(deck, temp, i);

            }

        }
        static string[] SwapCharacters(string[] array, int position1, int position2)
        {
            //Swap two index in array
            string temp = array[position1];
            array[position1] = array[position2];
            array[position2] = temp;
            return (array);
        }
    }
}