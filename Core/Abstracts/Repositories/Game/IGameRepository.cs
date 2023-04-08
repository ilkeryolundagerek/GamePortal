using Core.Concrates.Entities.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.DataTools;

namespace Core.Abstracts.Repositories.Game
{
    public interface IGameRepository : IGenericRepository<GameEntity>
    {
    }
}
