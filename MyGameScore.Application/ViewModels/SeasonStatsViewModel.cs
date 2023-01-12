namespace MyGameScore.Application.ViewModels
{
    public class SeasonStatsViewModel
    {
        public SeasonStatsViewModel(int gamesPlayed, int totalScore, double scoreAverage, int highestScore, int lowestScore, int timesRecordWasBeaten)
        {
            GamesPlayed = gamesPlayed;
            TotalScore = totalScore;
            ScoreAverage = scoreAverage;
            HighestScore = highestScore;
            LowestScore = lowestScore;
            TimesRecordWasBeaten = timesRecordWasBeaten;
        }

        public int GamesPlayed { get; private set; }
        public int TotalScore { get; private set; }
        public double ScoreAverage { get; private set; }
        public int HighestScore { get; private set; }
        public int LowestScore { get; private set; }
        public int TimesRecordWasBeaten { get; private set; }
    }
}
