using CodingLanguages.API.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodingLanguages.API.Model
{
    [Table("language")]
    public class Language : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("category")]
        [StringLength(50)]
        public string Category { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public string ImageUrl { get; set; }
    }
}
