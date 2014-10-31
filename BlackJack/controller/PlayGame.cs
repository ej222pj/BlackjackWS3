using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BlackJack.model;

namespace BlackJack.controller
{
    class PlayGame : IDealCard
    {
        private model.Game a_game;
        private view.IView a_view;

        public PlayGame(model.Game game, view.IView view)
        {
            a_game = game;
            a_view = view;
        }
        
        public bool Play()
        {
            char newgame = 'p';
            char hit = 'h';
            char stand = 's';
            char quit = 'q';

            a_view.DisplayWelcomeMessage();
            doOutput(a_game.IsGameOver());

            int input = a_view.GetInput();

            if (input == newgame)
            {
                Thread.Sleep(10);
                a_game.NewGame();
            }
            else if (input == hit)
            {
                Thread.Sleep(10);
                a_game.Hit();
            }
            else if (input == stand)
            {
                Thread.Sleep(10);
                a_game.Stand();
            }

            return input != quit;
        }

        public void DealCard() 
        {
            a_view.DisplayWelcomeMessage();
            doOutput(a_game.IsGameOver());
            System.Threading.Thread.Sleep(15);
        }

        public void doOutput(bool isGameOver)
        {
            if (isGameOver == true)
            {
                a_view.doOutput(a_game.GetDealerHand(), a_game.GetPlayerHand(), a_game.GetDealerScore(), a_game.GetPlayerScore(), true, a_game.IsDealerWinner());
            }
            else
            {
                a_view.doOutput(a_game.GetDealerHand(), a_game.GetPlayerHand(), a_game.GetDealerScore(), a_game.GetPlayerScore(), false, "dealer");
            }
        }
    }
}
