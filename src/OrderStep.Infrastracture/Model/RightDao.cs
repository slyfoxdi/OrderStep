using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Model
{
    internal class RightDao
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Описание возможности действия
        /// </summary>
        public string Name { get; set; }
    }
}
