using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kortleks_övning.Library;

// TODO 1. 

namespace Kortleks_övning.Library
{
    class Deck
    {
        Card card = new Card();
        Card[] cards = new Card[52];

        Deck()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (i <= 13)
                {
                    foreach (KeyValuePair<string, string> cardRank in card.cardDict)
                    {
                        cards[i].cardSuit = Card.CardSuits.Clubs;
                        string key = cardRank.Key;
                        cards[i].cardDict = cardRank.Value;
                    }
                }
                else if (i <= 26)
                {
                    for (int k = 0; k <= 13; k++)
                    {
                        cards[k].cardSuit = Card.CardSuits.Diamonds;
                    }
                }
                else if (i <= 39)
                {
                    for (int k = 0; k <= 13; k++)
                    {
                        cards[k].CardSuit = Card.CardSuits.Diamonds;
                    }
                }
                else if (i <= 52)
                {
                    for (int k = 0; k <= 13; k++)
                    {
                        cards[k].CardSuit = Card.CardSuits.Diamonds;
                    }
                }
            }
        }
    }
}
