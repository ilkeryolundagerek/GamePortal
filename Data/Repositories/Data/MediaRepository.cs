using Core.Abstracts.Repositories.Data;
using Core.Concrates.Entities.Data;
using System.Data.Entity;
using ToolBox.DataTools;

namespace Data.Repositories.Data
{
    public class MediaRepository : GenericRepository<MediaEntity>, IMediaRepository
    {
        public MediaRepository(DbContext context) : base(context)
        {
        }
    }
}
