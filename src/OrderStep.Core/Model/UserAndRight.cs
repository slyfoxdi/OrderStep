using OrderStep.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Core.Model
{
    public class UserAndRight
    {
        public AccessType Access { get; set; }

        public ActionType Action { get; set; }
    }
}
