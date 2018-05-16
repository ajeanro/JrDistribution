using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Category name is required")]
        [MaxLength(50, ErrorMessage = "The category name can be maximum 50 characters long")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
