namespace RefactoringKatas.Refactored.Replace_array_with_object
{
    public interface ILeaderBoardObserver
    {
        void DisplayTopTeamName(string teamName);
        void DisplayTopTeamWins(string teamWins);
        void DisplayTopTeamLosses(string teamLosses);
    }
}