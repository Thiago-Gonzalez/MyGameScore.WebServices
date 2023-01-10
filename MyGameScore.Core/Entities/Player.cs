namespace MyGameScore.Core.Entities
{
    public class Player : BaseEntity
    {
        public Player(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;

            Matches = new List<Match>();
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<Match> Matches { get; private set; }

        public void SetMatches(List<Match> matches)
        {
            Matches = matches;
        }

        public int GetGamesPlayed()
        {
            return Matches.Count;
        }

        public int GetTotalScore()
        {
            return Matches.Select(m => m.Score).Sum();
        }

        public double GetScoreAverage()
        {
            return Matches.Select(m => m.Score).Average();
        }

        public int GetHighestScore()
        {
            return Matches.Select(m => m.Score).Max();
        }

        public int GetLowestScore()
        {
            return Matches.Select(m => m.Score).Min();
        }

        public int GetTimesRecordWasBeaten()
        {
            var scores = Matches.OrderBy(m => m.Date).Select(m => m.Score).ToList();
            int timesRecordWasBeaten = 0;
            int record = scores[0];

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > record)
                {
                    record = scores[i];
                    timesRecordWasBeaten++;
                }
            }

            return timesRecordWasBeaten;
        }
    }
}
