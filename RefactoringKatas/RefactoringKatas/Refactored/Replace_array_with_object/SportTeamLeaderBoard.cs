using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringKatas.Refactored.Replace_array_with_object
{
    public class Performance
    {
        public string[] _Data;

        public Performance(string[] data, string name, string wins, string losses)
        {
            Name = name;
            Wins = wins;
            Losses = losses;
            _Data = data;
        }

        public string Name { get; private set; }
        public string Wins { get; private set; }
        public string Losses { get; private set; }
    }

    public class SportTeamLeaderBoard
    {
        private readonly Performance[] TeamData;

        public SportTeamLeaderBoard(params Performance[] teamData)
        {
            TeamData = teamData;
        }

        public void DisplayFor(ILeaderBoardObserver leaderBoardObserver)
        {
            var bestTeam = SelectBestTeam(TeamData);

            leaderBoardObserver.DisplayTopTeamName(bestTeam.Name);
            leaderBoardObserver.DisplayTopTeamWins(bestTeam.Wins);
            leaderBoardObserver.DisplayTopTeamLosses(bestTeam.Losses);
        }

        private static Performance SelectBestTeam(IEnumerable<Performance> teamsToSelectFrom)
        {
            return teamsToSelectFrom.First(leftTeam => teamsToSelectFrom.All(rightTeam => LeftTeamHasMoreWinsThanRightTeam(leftTeam, rightTeam)));
        }

        private static bool LeftTeamHasMoreWinsThanRightTeam(Performance leftTeam, Performance rightTeam)
        {
            var leftWins = Int32.Parse(leftTeam.Wins);
            var rightWins = Int32.Parse(rightTeam.Wins);
            return leftWins >= rightWins;
        }
    }
}