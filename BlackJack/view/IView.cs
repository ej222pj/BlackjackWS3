using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    interface IView
    {
        void DisplayWelcomeMessage();
        int GetInput();
        void DisplayCard(model.Card a_card);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(string a_dealerIsWinner);
        void doOutput(IEnumerable<model.Card> dealerHand, IEnumerable<model.Card> playerHand, int dealerScore, int playerScore, bool gameOver, string a_dealerIsWinner);
    }
}
