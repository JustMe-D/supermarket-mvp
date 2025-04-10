using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    internal class CategoryModel
    {

        [DisplayName("Category Id")]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters")]
        public string Description { get; set; }

    }
}
