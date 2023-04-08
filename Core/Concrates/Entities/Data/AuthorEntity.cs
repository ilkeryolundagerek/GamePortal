using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrates.Entities.Data
{
    [Table("tbl_authors")]
    public class AuthorEntity : BaseEntity
    {
        [Required]
        public string UserId { get; set; }
        public virtual ICollection<ArticleEntity> Articles { get; set; }
    }
}
