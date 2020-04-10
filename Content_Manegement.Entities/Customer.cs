using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Entities
{
  public  class Customer
    {
        public virtual int CustomerId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Password { get; set; }

    }
}
