using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public interface IView
    {
        int MainMenu();
        void EndMessage();
        void InvalidOption();
        void AfterMenu();
        Player InsertPlayer();
        void ListPlayers(IEnumerable<Player> playersToList);
        int AskForMinimumScore();
        PlayerOrder AskForPlayerOrder();
    }
}