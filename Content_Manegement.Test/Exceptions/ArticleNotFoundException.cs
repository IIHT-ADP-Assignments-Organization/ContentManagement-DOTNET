using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Test.Exceptions
{
   public class ArticleNotFoundException:Exception
    {
        public string Messages = " Article Not Found ";

        public ArticleNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
