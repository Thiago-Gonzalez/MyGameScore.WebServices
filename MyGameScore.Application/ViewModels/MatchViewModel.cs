namespace MyGameScore.Application.ViewModels
{
    public class MatchViewModel
    {
        public MatchViewModel(int id, DateTime date, int score, string playerName)
        {
            Id = id;
            Date = date;
            Score = score;
            PlayerName = playerName;
        }

        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public int Score { get; private set; }
        public string PlayerName { get; private set; }
    }
}
