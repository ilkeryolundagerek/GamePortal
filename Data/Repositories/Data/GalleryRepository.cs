using Core.Abstracts.Repositories.Data;
using Core.Concrates.Entities.Data;
using System.Data.Entity;
using ToolBox.DataTools;

namespace Data.Repositories.Data
{
    public class GalleryRepository : GenericRepository<GalleryEntity>, IGalleryRepository
    {
        public GalleryRepository(DbContext context) : base(context)
        {
        }
    }
}
