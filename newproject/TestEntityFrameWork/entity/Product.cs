using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace newproject.TestEntityFrameWork.entity
{
    [Table("Product")]
    public class Product{
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]

        public string Name { get; set; }
        [StringLength(50)]
        public decimal Price { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
    }
}