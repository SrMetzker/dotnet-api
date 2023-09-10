using dotnet_api.Models.ClientModels;

namespace dotnet_api.Repositories
{
    public interface IClientRepository
    {
        /// <summary>
        /// Cadastro um novo Cliente
        /// </summary>
        /// <param name="client">Objeto com as informações do cliente que será cadastrado</param>
        /// <returns>Retorna o objeto <c>Client</c> que foi cadastrado</returns>
        public Task<ClientModel> RegisterClient(ClientModel client);

        /// <summary>
        /// Resgata um cliente pelo ID
        /// </summary>
        /// <param name="clientId">ID do cliente</param>
        /// <returns>Retona o cliente encontrado ou <c>null</c></returns>
        public Task<ClientModel?> GetClienById(int id);

        /// <summary>
        /// Resgata todos os clientes cadastrados por um determinado usuário
        /// </summary>
        /// <param name="id">ID do usuário</param>
        /// <returns>Lista contendo todos os clientes cadastrados pelo usuário</returns>
        public Task<IReadOnlyList<ClientModel>> GetUserRelatedClient(int id);

        /// <summary>
        /// Deleta um cliente
        /// </summary>
        /// <param name="client">Cliente para deletar</param>
        /// <returns>Informações do cliente deletado</returns>
        public ClientModel DeleteClient(ClientModel client);

        /// <summary>
        /// Aplica as alterações executados no banco de dados
        /// </summary>
        public Task FlushChanges();
    }
}
