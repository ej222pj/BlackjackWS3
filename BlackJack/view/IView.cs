﻿using System;
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
        void doOutput(IEnumerable<model.Card> dealerHand, IEnumerable<model.Card> playerHand, int dealerScore, int playerScore, bool gameOver, string a_dealerIsWinner);
    }
}
