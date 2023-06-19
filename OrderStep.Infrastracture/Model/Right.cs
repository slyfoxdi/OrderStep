﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Model
{
    public class Right
    {
        [Key]
        public int RightId { get; set; }

        /// <summary>
        /// Описание возможности действия
        /// </summary>
        public string Name { get; set; }
    }
}
