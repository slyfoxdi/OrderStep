using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Core.Exceptions
{
    public class InfrastractureException : Exception
    {
        public InfrastractureException(string message) : base(message) { }
    }
}
