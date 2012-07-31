using System;
using System.Collections.Generic;

namespace AspForum.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Parent { get; set; }
    }
}