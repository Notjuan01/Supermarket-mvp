using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Xunit;

namespace Supermarket_mvp.Models
{
    internal class Categories
    {
        [DisplayName("Categories Id")]
        public int Id { get; set; }
        [DisplayName("Categories Name")]
        [Required(ErrorMessage = "Categories Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Categories name must be between 3 and 50 characters")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
