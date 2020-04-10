using System;
using System.Collections.Generic;
using System.Text;

namespace Content_Manegement.Test.Exceptions
{
    public class FieldscannotEmptyException:Exception
    {
        public string Messages = " Field can not be blanck ";

        public FieldscannotEmptyException(string message)
        {
            Messages = message;
        }
    }
}
