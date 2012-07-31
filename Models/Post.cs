using System;
using System.Collections.Generic;

namespace AspForum.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int TopicID { get; set; }
        public string Message { get; set; }
        public DateTime PostingDate { get; set; }
        public virtual Topic Topic { get; set; }
    }
}