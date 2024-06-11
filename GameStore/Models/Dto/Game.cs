namespace GameStore.Models.Dto;

public record Game
{
    public Game(string? name, string description, string? version, string ageRestirction,DateTime? publishDate, string[]? tags) {}
}
