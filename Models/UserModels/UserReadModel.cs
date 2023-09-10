namespace dotnet_api.Models.UserModels
{
    public class UserReadModel
    {
        public string Name { get; init; }  = string.Empty;
        public string Email { get; init; } = string.Empty;

        /// <summary>
        /// Converte um <c>UserModel</c> em um <c>UserReadModel</c> 
        /// </summary>
        /// <param name="userModel"><c>UserModel</c> que será convertido</param>
        /// <returns>Um novo <c>UserReadModel</c> referente ao <c>UserModel</c></returns>
        public static UserReadModel FromUserModel(UserModel userModel) => new()
        {
            Name  = userModel.Name,
            Email = userModel.Email
        };
    }
}
