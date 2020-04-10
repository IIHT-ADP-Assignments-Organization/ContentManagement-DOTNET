using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Test.Exceptions
{
  public  class EmailNotFoundException:Exception
    {
        public string Messages = " Email Not Found ";

        public EmailNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
