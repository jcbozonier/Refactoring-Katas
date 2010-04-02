using RefactoringKatas.Refactored.Replace_array_with_object;

namespace RefactoringKata_Tests.Refactored.Replace_array_with_object.ObjectsCreatedForTesting
{
    public class ReportingLeaderBoardObserver : ILeaderBoardObserver
    {
        public string TopTeamNameDisplayed;
        public string TopTeamWinsDisplayed;
        public string TopTeamLossesDisplayed;

        public void DisplayTopTeamName(string teamName)
        {
            TopTeamNameDisplayed = teamName;
        }

        public void DisplayTopTeamWins(string teamWins)
        {
            TopTeamWinsDisplayed = teamWins;
        }

        public void DisplayTopTeamLosses(string teamLosses)
        {
            TopTeamLossesDisplayed = teamLosses;
        }
    }
}