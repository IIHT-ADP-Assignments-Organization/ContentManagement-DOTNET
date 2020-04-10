using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Entities
{
   public class Banners
    {
        public virtual int BannerId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual string Iamges { get; set; }
        public virtual string Width { get; set; }
        public virtual string Height { get; set; }
        public virtual string AltText { get; set; }
        public virtual string Description { get; set; }
    }
}
