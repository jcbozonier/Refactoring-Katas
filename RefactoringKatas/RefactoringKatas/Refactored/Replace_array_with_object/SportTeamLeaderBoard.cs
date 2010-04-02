using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringKatas.Refactored.Replace_array_with_object
{
    public class SportTeamLeaderBoard
    {
        private readonly string[][] TeamData;

        public SportTeamLeaderBoard(params string[][] teamData)
        {
            TeamData = teamData;
        }

        public void DisplayFor(ILeaderBoardObserver leaderBoardObserver)
        {
            var bestTeam = SelectBestTeam(TeamData);

            leaderBoardObserver.DisplayTopTeamName(bestTeam[0]);
            leaderBoardObserver.DisplayTopTeamWins(bestTeam[1]);
            leaderBoardObserver.DisplayTopTeamLosses(bestTeam[2]);
        }

        private static string[] SelectBestTeam(IEnumerable<string[]> teamsToSelectFrom)
        {
            return teamsToSelectFrom.First(leftTeam => teamsToSelectFrom.All(rightTeam => LeftTeamHasMoreWinsThanRightTeam(leftTeam, rightTeam)));
        }

        private static bool LeftTeamHasMoreWinsThanRightTeam(IList<string> leftTeam, IList<string> rightTeam)
        {
            var leftWins = Int32.Parse(leftTeam[1]);
            var rightWins = Int32.Parse(rightTeam[1]);
            return leftWins >= rightWins;
        }
    }
}