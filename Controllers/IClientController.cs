﻿using dotnet_api.Models.ClientModels;

namespace dotnet_api.Controllers
{
    public interface IClientController
    {
        /// <summary>
        /// Cadastrar um novo cliente
        /// </summary>
        /// <param name="registerRequestModel">Requisição de cadastro do cliente</param>
        /// <returns>O ID do novo cliente</returns>
        public Task<int> RegisterClient(ClientRegisterRequestModel registerRequestModel, int userId);

        /// <summary>
        /// Recupera os clientes cadastrados por um usuário
        /// </summary>
        /// <param name="userId">ID do usuario</param>
        /// <returns>Uma lista dos clientes cadastrados pelo usuario</returns>
        public Task<IReadOnlyList<ClientReadModel>> GetUserClients(int userId);

        /// <summary>
        /// Atualiza os dados de um cliente
        /// </summary>
        /// <param name="updateRequest">Requisição de atualização com as novas informações do cliente</param>
        /// <param name="clientId">ID do cliente que será atualizado</param>
        /// <returns>O ID do cliente atualizado</returns>
        public Task<int> UpdateClient(ClientUpdateRequestModel updateRequest, int clientId);

        /// <summary>
        /// Deleta um cliente
        /// </summary>
        /// <param name="clientId">ID do cliente que será deletado</param>
        /// <returns>O ID do cliente deletado</returns>
        public Task<int> DeleteClient(int clientId);
    }
}
