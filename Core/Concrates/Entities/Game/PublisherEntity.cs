using Core.Abstracts.Bases;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concrates.Entities.Game
{
    [Table("tbl_publishers")]
    public class PublisherEntity : BaseEntity
    {
        public string FeatureMedia { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GameEntity> Games { get; set; }
    }
}
