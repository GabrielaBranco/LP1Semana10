using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class Controller
    {
        private readonly List<Player> playerList;
        private readonly IComparer<Player> compareByName;
        private readonly IComparer<Player> compareByNameReverse;
        private IView view;

        public Controller(List<Player> players)
        {
            compareByName = new CompareByName(true);
            compareByNameReverse = new CompareByName(false);

            playerList = players;
        }

        public void Start(IView view)
        {
            this.view = view;
            int option;
            do
            {
                option = view.MainMenu();
                switch (option)
                {
                    case 1:
                        InsertPlayer();
                        break;
                    case 2:
                        view.ListPlayers(playerList);
                        break;
                    case 3:
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case 4:
                        SortPlayerList();
                        break;
                    case 0:
                        view.EndMessage();
                        break;
                    default:
                        view.InvalidOption();
                        break;
                }
                view.AfterMenu();
            } while (option != 0);
        }

        private void InsertPlayer()
        {
            Player newPlayer = view.InsertPlayer();
            playerList.Add(newPlayer);
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            int minScore;
            IEnumerable<Player> playersWithScoreGreaterThan;
            minScore = view.AskForMinimumScore();

            playersWithScoreGreaterThan = GetPlayersWithScoreGreaterThan(minScore);

            view.ListPlayers(playersWithScoreGreaterThan);
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (Player p in playerList)
            {
                if (p.Score > minScore)
                {
                    yield return p;
                }
            }
        }
        private void SortPlayerList()
        {
            PlayerOrder playerOrder;
            playerOrder = view.AskForPlayerOrder();
            
            switch (playerOrder)
            {
                case PlayerOrder.ByScore:
                    playerList.Sort();
                    break;
                case PlayerOrder.ByName:
                    playerList.Sort(compareByName);
                    break;
                case PlayerOrder.ByNameReverse:
                    playerList.Sort(compareByNameReverse);
                    break;
                default:
                    view.InvalidOption();
                    break;
            }
        }
    }
}
