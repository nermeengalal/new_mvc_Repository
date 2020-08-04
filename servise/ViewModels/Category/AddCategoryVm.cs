using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewModels.Category
{
    public class AddCategoryVm
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string Category_Name { get; set; }
    }
}
