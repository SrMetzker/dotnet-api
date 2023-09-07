using dotnet_api.Models.UserModels;

namespace dotnet_api.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Cadastra um novo usuário.
        /// </summary>
        /// <param name="user">Usuário que será cadastrado</param>
        /// <returns>Retorna o usuário cadastrado</returns>
        public Task<UserModel> RegisterUser(UserModel user);

        /// <summary>
        /// Obtém um usuário através do <c>ID</c>
        /// </summary>
        /// <param name="userId">ID do usuário</param>
        /// <returns>Retorna o usuário obtido através do ID ou <c>Null</c></returns>
        public Task<UserModel?> GetUserId(int id);

        /// <summary>
        /// Obté um usuário através do <c>nome</c>
        /// </summary>
        /// <param name="name">Nome do usuário</param>
        /// <returns>Retorna o usuário de nome igual ao informado no parametro ou <c>Null</c></returns>
        public Task<UserModel> GetUserByName(string name);

        /// <summary>
        /// Aplica as alterações executados no banco de dados
        /// </summary>
        public Task FlushChanges();
    }
}
