using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Entities
{
    public class Articles
    {
        public virtual int ArticleId { get; set; }
        public virtual string Description { get; set; }
        public virtual string Title { get; set; }
        public virtual string Status { get; set; }
        public virtual string Category { get; set; }
        public virtual string Featured { get; set; }
        public virtual string Access { get; set; }
        public virtual string Language { get; set; }
        public virtual string Tags { get; set; }
        public virtual string Note { get; set; }
        public virtual int CustomerId { get; set; }
    }
}
