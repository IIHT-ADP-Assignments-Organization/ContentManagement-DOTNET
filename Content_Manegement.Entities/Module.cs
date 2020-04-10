using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Entities
{
   public class Module
    {
        public virtual int ModuleId { get; set; }
        public virtual string Title { get; set; }
        public virtual string ShowTitle { get; set; }
        public virtual string Status { get; set; }
        public virtual string Position { get; set; }
        public virtual DateTime StartPublishing { get; set; }
        public virtual string Access { get; set; }
        public virtual DateTime finishPublishing { get; set; }
        public virtual string Ordering { get; set; }
        public virtual string Language { get; set; }
    }
}
