using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Entities
{
   public class Admin
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}
