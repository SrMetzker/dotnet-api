using System.Text.RegularExpressions;

namespace dotnet_api.Endpoints
{
    public static class UserEndpoints
    {
        public static RouteGroupBuilder MapUserEndpoints(this RouteGroupBuilder group)
        {
            group.MapPost("signin", (HttpContext context) => Results.Created("user/sigin", null));

            group.MapPost("login", (HttpContext context) => Results.Ok("Logar Usuário!"));

            return group;
        }
    }
}
