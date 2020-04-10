using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Entities
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string ParentCategory { get; set; }
        public virtual string Access { get; set; }
        public virtual string Language { get; set; }
        public virtual string Tags { get; set; }
        public virtual string Note { get; set; }
        public virtual string Image { get; set; }
        public virtual string AltText { get; set; }
    }
}
