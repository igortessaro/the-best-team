namespace Pokemon.TheBestTeam.Api.Models;
{
    public record Trainer(
        string name,
        string password,
        string email,
        string nickname,
        string image
    );
}
