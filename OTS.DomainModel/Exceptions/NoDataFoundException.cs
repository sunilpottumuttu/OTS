using System;
using System.Collections.Generic;
using System.Text;

namespace OTS.DomainModel.Exceptions
{
    public class NoDataFoundException : Exception
    {
        public NoDataFoundException(string message):base(message)
        {

        }
    }
}
