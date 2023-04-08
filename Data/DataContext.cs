using Core.Concrates.Entities.Account;
using Core.Concrates.Entities.Data;
using Core.Concrates.Entities.Game;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("data")
        {
        }
        public virtual DbSet<ArticleEntity> Articles { get; set; }
        public virtual DbSet<AuthorEntity> Authors { get; set; }
        public virtual DbSet<GalleryEntity> Galleries { get; set; }
        public virtual DbSet<MediaEntity> Medias { get; set; }
    }

    public class GameContext : DbContext
    {
        public GameContext() : base("game")
        {
        }
        public virtual DbSet<GameEntity> GameEntities { get; set; }
        public virtual DbSet<DeveloperEntity> DeveloperEntities { get; set; }
        public virtual DbSet<GamePlatformEntity> GamePlatformEntities { get; set; }
        public virtual DbSet<GenreEntity> GenreEntities { get; set; }
        public virtual DbSet<PlayerEntity> PlayerEntities { get; set; }
        public virtual DbSet<PublisherEntity> PublisherEntities { get; set; }

    }

    public class AccountContext : IdentityDbContext<User, Role, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    {
        public AccountContext() : base("account")
        {
        }
    }
}
