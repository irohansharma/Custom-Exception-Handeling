using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandeling
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }


}
