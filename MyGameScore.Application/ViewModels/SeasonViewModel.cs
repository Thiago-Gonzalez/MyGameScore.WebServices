using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGameScore.Core.Entities;

namespace MyGameScore.Application.ViewModels
{
    public class SeasonViewModel
    {
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? SeasonStart { get; private set; }
        public DateTime? SeasonEnd { get; private set; }
        public List<MatchViewModel> Matches { get; private set; }

        public SeasonViewModel(int id, DateTime createdAt, DateTime? seasonStart, DateTime? seasonEnd, List<MatchViewModel> matches)
        {
            Id = id;
            CreatedAt = createdAt;
            SeasonStart = seasonStart;
            SeasonEnd = seasonEnd;
            Matches = matches;            
        }
    }
}