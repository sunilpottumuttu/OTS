using System;
using System.Collections.Generic;
using System.Text;

namespace OTS.DomainModel.Exceptions
{
    public class InvalidDataException: Exception
    {
        public InvalidDataException(string message):base(message)
        {

        }
    }
}
