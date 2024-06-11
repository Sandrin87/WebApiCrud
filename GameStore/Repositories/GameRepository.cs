using GameStore.Models.Dto;
using GameStore.Repositories.Interfaces;

namespace GameStore.Repositories;

public class GameRepository : IGameRepository
{
    private readonly IGameRepository _gameRepository;
    private readonly ILogger<GameRepository> _logger;

    public GameRepository(IGameRepository gameRepository, ILogger<GameRepository> logger)
    {
        _gameRepository = gameRepository;
        _logger = logger;
    }

    public bool Create(Game game)
    {
        throw new NotImplementedException();
    }

    public bool Update(int gameId)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int gameId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Game> GetAll()
    {
        throw new NotImplementedException();
    }

    public Game GetByName(string name)
    {
        throw new NotImplementedException();
    }
}
