namespace MyGameScore.Application.ViewModels
{
    public class PlayerViewModel
    {
        public PlayerViewModel(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
