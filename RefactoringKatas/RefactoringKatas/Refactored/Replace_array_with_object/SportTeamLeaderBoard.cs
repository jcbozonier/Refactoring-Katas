using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringKatas.Refactored.Replace_array_with_object
{
    public class SportTeamLeaderBoard
    {
        private readonly IEnumerable<Performance> TeamData;

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