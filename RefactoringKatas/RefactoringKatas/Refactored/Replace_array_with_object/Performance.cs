namespace RefactoringKatas.Refactored.Replace_array_with_object
{
    public class Performance
    {
        public Performance(string name, string wins, string losses)
        {
            Name = name;
            Wins = wins;
            Losses = losses;
        }

        public string Name { get; private set; }
        public string Wins { get; private set; }
        public string Losses { get; private set; }
    }
}