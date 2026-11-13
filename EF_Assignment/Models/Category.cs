using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment.Models
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
