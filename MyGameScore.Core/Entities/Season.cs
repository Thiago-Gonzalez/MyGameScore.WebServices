using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameScore.Core.Entities
{
    public class Season : BaseEntity
    {
        public DateTime CreatedAt { get; private set; }
        public DateTime? SeasonStart { get; private set; }
        public DateTime? SeasonEnd { get; private set; }
        public List<Match> Matches { get; private set; }
        public int IdPlayer { get; private set; }
        public Player Player { get; private set; }

        public Season(int idPlayer)
        {
            IdPlayer = idPlayer;
            CreatedAt = DateTime.Now;
            Matches = new List<Match>();
        }

        public void SetMatches(List<Match> matches)
        {
            Matches = matches;
        }

        public void SetSeasonStart()
        {
            if (Matches.Count > 0) SeasonStart = Matches.Select(m => m.Date).Min();
        }

        public void SetSeasonEnd()
        {
            if (Matches.Count > 0) SeasonEnd = Matches.Select(m => m.Date).Max();
        }

        public void Update()
        {
            SetSeasonStart();
            SetSeasonEnd();
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