namespace MyGameScore.Application.ViewModels
{
    public class LoginPlayerViewModel
    {
        public LoginPlayerViewModel(int id, string email, string token)
        {
            Id = id;
            Email = email;
            Token = token;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Token { get; private set; }
    }
}
