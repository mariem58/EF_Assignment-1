using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment.Models
{

    internal class Book 
    {
        public int BookId { get; set; }
        public string ISBN { get; set; }
        public string title { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishedYears { get; set; }

        public bool IsInStock { get; set; }

    }
}
