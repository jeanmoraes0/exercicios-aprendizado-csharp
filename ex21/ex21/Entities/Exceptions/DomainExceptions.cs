using System;

namespace ex21.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
            
        }
    }
}