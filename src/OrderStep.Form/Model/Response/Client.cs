using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Model
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Role { get; set; }
    }
}
