using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [MaxLength(50, ErrorMessage = "The maximum length must be up to 50 characters only")]
        public string Name { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Has to be decimal with two decimal points")]
        [Range(0, 5, ErrorMessage = "The maximum possible value should be up to 5 digits")]
        public Decimal Price { get; set; }


        public string Description { get; set; }

        [Display(Name = "Updated At")]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
    }
}
