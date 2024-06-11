using GameStore.Models.Dto;

namespace GameStore.Repositories.Interfaces;

public interface IGameRepository
{
    bool Create(Game game);

    IEnumerable<Game> GetAll();

    Game GetByName(string name);

    bool Update(int gameId);

    bool Delete(int gameId);
}
