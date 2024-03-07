using BlazorCrudDotnet8.Shared.Data;
using BlazorCrudDotnet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotnet8.Shared.Services
{
    // impementation of interface methods
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<Game> AddGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return game;
        }

        public async Task<bool> DeleteGame(int id)
        {
            // we are looking for sepcific game according to the id
            var dbGame = await _context.Games.FindAsync(id);
            if (dbGame != null)
            {
                _context.Remove(dbGame);
                _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Game> EditGame(int id, Game game)
        {
            var dbGame = await _context.Games.FindAsync(id);
            if (dbGame != null)
            {
                // assign new values instead of old ones
                dbGame.Name = game.Name;
                await _context.SaveChangesAsync();
                return dbGame;
            }
            throw new Exception("Game not found.");
        }

        public async Task<List<Game>> GetAllGames()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }

        public async Task<Game> GetGameById(int id)
        {
            return await _context.Games.FindAsync(id);
        }
    }
}
