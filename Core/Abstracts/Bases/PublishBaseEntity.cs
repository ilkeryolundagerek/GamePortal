using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Abstracts.Bases
{
    public abstract class PublishBaseEntity : BaseEntity
    {
        public string Description { get; set; }
        public Nullable<DateTime> PublishDate { get; set; }
        public bool Draft { get; set; } = true;
        [MaxLength(500)]
        public string SubTitle { get; set; }
    }
}
