using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame
    {
        
        public bool Play(model.Game a_game, view.IView a_view)
        {
            char newgame = 'p';
            char hit = 'h';
            char stand = 's';
            char quit = 'q';

            a_view.DisplayWelcomeMessage();
            
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            int input = a_view.GetInput();

            if (input == newgame)
            {
                a_game.NewGame();
            }
            else if (input == hit)
            {
                a_game.Hit();
            }
            else if (input == stand)
            {
                a_game.Stand();
            }

            return input != quit;
        }
    }
}
