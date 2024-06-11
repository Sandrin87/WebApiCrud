using GameStore.Models.Dto;

namespace GameStore.Services.Interfaces;

public interface IGameService
{
    Game Create(Game game);

    Game Update(int gameId);

    bool Delete(int gameId);

    List<Game> GetAll();

    Game GetByName(string name);
}
