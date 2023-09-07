using dotnet_api.Models.UserModels;

namespace dotnet_api.Models.ClientModels
{
    public class ClientReadModel
    {
        public int Id { get; init; }                  = 0;
        public string Name{ get; init; }              = string.Empty;
        public UserReadModel? CreatedBy { get; init; } = null;

        /// <summary>
        /// Converte um <c>ClientModel</c> em um <c>ClientReadModel</c> 
        /// </summary>
        /// <param name="clientModel"><c>ClientModel</c> que será convertido</param>
        /// <returns>Um novo <c>ClientReadModel</c> referente ao <c>ClientModel</c></returns>
        public static ClientReadModel FromClientModel(ClientModel clientModel) => new()
        {
            Id        = clientModel.Id,
            Name      = clientModel.Name,
            CreatedBy = UserReadModel.FromUserModel(clientModel.CreatedBy)
        };
    }
}
