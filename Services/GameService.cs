using Core.Abstracts.Repositories.Game;
using Core.Abstracts.Services.Game;
using Core.Concrates.DTOs.Game;
using Data;
using Data.Repositories.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Services
{
    public class GameService : IGameService
    {
        private GameContext _context;
        private GameRepository game;
        public IGameRepository GameRepository => game = game ?? new GameRepository(_context);

        public GameService(GameContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GameListDTO>> GetGames(Expression<Func<GameListDTO, bool>> expression = null)
        {
            return from x in await game.FindAsync()
                   select new GameListDTO
                   {
                       Id = x.Id,
                       Title = x.Title,
                       SubTitle = x.SubTitle,
                       Status = x.Status,
                       Rating = x.Rating,
                       Publisher = x.Publisher.Title,
                       Developer = x.Developer.Title,
                       FeatureMedia = x.FeatureMedia,
                       Logo = x.Logo,
                       PlatformIcons = x.Platforms.Select(y => y.PlatformName.ToString())
                   };
        }
    }
}
