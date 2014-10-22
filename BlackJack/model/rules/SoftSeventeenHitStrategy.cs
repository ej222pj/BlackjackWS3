using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class SoftSeventeenHitStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;



        public bool DoHit(model.Player a_dealer)
        {
            IEnumerable<Card> cardList = a_dealer.GetHand();
            if(a_dealer.CalcScore() < g_hitLimit)
            {
                return true;
            }

            if (a_dealer.CalcScore() == g_hitLimit)
            {
                foreach(Card card in cardList)
                {
                    if(card.GetValue() == Card.Value.Ace && a_dealer.CalcScore() < 17)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
