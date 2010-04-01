using NUnit.Framework;
using RefactoringKata_Tests.Replace_array_with_object.ObjectsCreatedForTesting;
using RefactoringKatas.Replace_array_with_object;

namespace RefactoringKata_Tests.Replace_array_with_object
{
    namespace Given.a_sports_leaderboard.with_two_teams
    {
        [TestFixture]
        public class When_displaying_the_top_team
        {
            [Test]
            public void It_should_display_the_team_name_with_the_most_wins()
            {
                Assert.That(LeaderBoardObserver.TopTeamNameDisplayed, Is.EqualTo(BestTeamName));
            }

            [Test]
            public void It_should_display_the_displayed_team_names_wins()
            {
                Assert.That(LeaderBoardObserver.TopTeamWinsDisplayed, Is.EqualTo(BestTeamWins));
            }

            [Test]
            public void It_should_display_the_displayed_team_names_losses()
            {
                Assert.That(LeaderBoardObserver.TopTeamLossesDisplayed, Is.EqualTo(BestTeamLosses));
            }

            [TestFixtureSetUp]
            public void Setup()
            {
                LeaderBoardObserver = new ReportingLeaderBoardObserver();
                BestTeamName = "Jetsons";
                BestTeamWins = "20";
                BestTeamLosses = "4";

                string WorstTeamName = "No one";
                var WorstTeamWins = "1";
                var WorstTeamLosses = "24";
                LeaderBoard = new SportTeamLeaderBoard(
                    new[] { BestTeamName, BestTeamWins, BestTeamLosses },
                    new[] { WorstTeamName, WorstTeamWins, WorstTeamLosses });
                LeaderBoard.DisplayFor(LeaderBoardObserver);
            }

            private SportTeamLeaderBoard LeaderBoard;
            private ReportingLeaderBoardObserver LeaderBoardObserver;
            private string BestTeamName;
            private string BestTeamWins;
            private string BestTeamLosses;
        }
    }

    namespace Given.a_sports_leaderboard.with_one_team
    {
        [TestFixture]
        public class When_displaying_the_top_team
        {
            [Test]
            public void It_should_display_the_team_name_with_the_most_wins()
            {
                Assert.That(LeaderBoardObserver.TopTeamNameDisplayed, Is.EqualTo(TeamName));
            }

            [Test]
            public void It_should_display_the_displayed_team_names_wins()
            {
                Assert.That(LeaderBoardObserver.TopTeamWinsDisplayed, Is.EqualTo(TeamWins));
            }

            [Test]
            public void It_should_display_the_displayed_team_names_losses()
            {
                Assert.That(LeaderBoardObserver.TopTeamLossesDisplayed, Is.EqualTo(TeamLosses));
            }

            [TestFixtureSetUp]
            public void Setup()
            {
                LeaderBoardObserver = new ReportingLeaderBoardObserver();
                TeamWins = "15";
                TeamLosses = "10";
                LeaderBoard = new SportTeamLeaderBoard(new []{TeamName, TeamWins, TeamLosses});
                LeaderBoard.DisplayFor(LeaderBoardObserver);
            }

            private SportTeamLeaderBoard LeaderBoard;
            private ReportingLeaderBoardObserver LeaderBoardObserver;
            private string TeamName = "Liverpool";
            private string TeamWins;
            private string TeamLosses;
        }
    }
    
}
