using Core.Abstracts.Bases;
using Core.Concrates.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Concrates.Entities.Data
{
    [Table("tbl_galleries")]
    public class GalleryEntity : BaseEntity
    {
        public GalleryTypes GalleryType { get; set; }
        public string ContentId { get; set; }
    }
}
