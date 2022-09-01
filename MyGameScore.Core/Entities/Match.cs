namespace MyGameScore.Core.Entities
{
    public class Match : BaseEntity
    {
        public Match(int idPlayer, DateTime date, int score)
        {
            IdPlayer = idPlayer;
            Date = date;
            Score = score;
        }

        public int IdPlayer { get; private set; }
        public Player Player { get; private set; }
        public DateTime Date { get; private set; }
        public int Score { get; private set; }

        public void Update(DateTime date, int score) 
        {
            Date = date;
            Score = score;
        }
    }
}
