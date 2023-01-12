namespace MyGameScore.Core.Entities
{
    public class Player : BaseEntity
    {
        public Player(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;

            Seasons = new List<Season>();
            Matches = new List<Match>();
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<Season> Seasons { get; private set; }
        public List<Match> Matches { get; private set; }
    }
}
