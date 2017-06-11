using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO 1. Change class name from Class1 to Card
// TODO 2. Change class file name from Class1.cs to Card.cs

// TODO 3. Add method X()

namespace Kortleks_övning.Library
{
    public class Card
    {
        public enum CardSuits { Clubs = 'C', Diamonds = 'D', Hearts = 'H', Spades = 'S'}
        public CardSuits cardSuit { get; set; }
        public Dictionary<string, string> cardDict = new Dictionary<string, string>()
        {
            {"Ace", "a"},
            {"Two", "2"},
            {"Three", "3"},
            {"Four", "4"},
            {"Five", "5"},
            {"Six", "6"},
            {"Seven", "7"},
            {"Eight", "8"},
            {"Nine", "9"},
            {"Ten", "10"},
            {"Jack", "J"},
            {"Queen", "Q"},
            {"King", "K"}
        };

        public override string ToString()
        {
            return string.Format("{0} of {1}", cardDict, cardSuit);
        }
    }
}
