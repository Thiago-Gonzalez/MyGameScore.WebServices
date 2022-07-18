namespace MyGameScore.Application.ViewModels
{
    public class LoginPlayerViewModel
    {
        public LoginPlayerViewModel(string email, string token)
        {
            Email = email;
            Token = token;
        }

        public string Email { get; private set; }
        public string Token { get; private set; }
    }
}
