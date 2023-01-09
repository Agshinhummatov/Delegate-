using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabe_Delegate.Exceptions
{
    internal class InvalidLoginException : Exception
    {
        public InvalidLoginException(string massage):base(massage) 
        {

        }

    }
}
