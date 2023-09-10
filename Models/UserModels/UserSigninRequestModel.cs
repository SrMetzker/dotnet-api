namespace dotnet_api.Models.UserModels
{
    public class UserSigninRequestModel
    {
        public string Name{ get; init; }      = string.Empty;
        public string Email { get; init; }    = string.Empty;
        public string Password { get; init; } = string.Empty;
    }
}
