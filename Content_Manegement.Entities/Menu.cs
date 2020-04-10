using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Entities
{
   public class Menu
    {
        public virtual int MenuId { get; set; }
        public virtual string Title { get; set; }
        public virtual string MenuType { get; set; }
        public virtual string Description { get; set; }
        public virtual string TitMenuPermision { get; set; }
    }
}
