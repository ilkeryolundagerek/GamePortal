using Core.Abstracts.Bases;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concrates.Entities.Game
{
    [Table("tbl_players")]
    public class PlayerEntity : BaseEntity
    {
        [Required]
        public string UserId { get; set; }
        public virtual ICollection<GameEntity> Games { get; set; }
    }
}
