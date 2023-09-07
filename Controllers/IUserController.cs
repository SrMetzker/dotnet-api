using dotnet_api.Models.UserModels;

namespace dotnet_api.Controllers
{
    public interface IUserController
    {
        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="signinRequest">Requisição de cadastro do usuário</param>
        /// <returns>Retorna um novo JWT para o usuário</returns>
        public Task<string> SigninUser(UserSigninRequestModel signinRequest);

        /// <summary>
        /// Autentica um usuário
        /// </summary>
        /// <param name="loginRequest">Requisição de login do usuário</param>
        /// <returns>Retorna um novo JWT para o usuário</returns>
        public Task<string> LoginUser(UserLoginRequestModel loginRequest);
    }
}
