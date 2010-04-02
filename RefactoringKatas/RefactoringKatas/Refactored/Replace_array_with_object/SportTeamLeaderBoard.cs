using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringKatas.Refactored.Replace_array_with_object
{
    public class Performance
    {
        public string[] _Data;

        public Performance(string[] data, string name)
        {
            Name = name;
            _Data = data;
        }

        public string Name { get; private set; }
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
            leaderBoardObserver.DisplayTopTeamWins(bestTeam._Data[1]);
            leaderBoardObserver.DisplayTopTeamLosses(bestTeam._Data[2]);
        }

        private static Performance SelectBestTeam(IEnumerable<Performance> teamsToSelectFrom)
        {
            return teamsToSelectFrom.First(leftTeam => teamsToSelectFrom.All(rightTeam => LeftTeamHasMoreWinsThanRightTeam(leftTeam, rightTeam)));
        }

        private static bool LeftTeamHasMoreWinsThanRightTeam(Performance leftTeam, Performance rightTeam)
        {
            var leftWins = Int32.Parse(leftTeam._Data[1]);
            var rightWins = Int32.Parse(rightTeam._Data[1]);
            return leftWins >= rightWins;
        }
    }
}