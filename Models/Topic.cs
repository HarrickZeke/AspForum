using System;
using System.Collections.Generic;

namespace AspForum.Models
{
    public class Topic
    {
        public int TopicID { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual Category Category { get; set; }
    }
}