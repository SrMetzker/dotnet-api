namespace dotnet_api.Models.UserModels
{
    public class UserLoginRequestModel
    {
        public string Name{ get; init; }      = string.Empty;
        public string Password { get; init; } = string.Empty;
    }
}
