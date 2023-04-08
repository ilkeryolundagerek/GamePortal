using Core.Abstracts.Bases;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concrates.Entities.Game
{
    [Table("tbl_developers")]
    public class DeveloperEntity : BaseEntity
    {
        public virtual ICollection<GameEntity> Games { get; set; }
    }
}
