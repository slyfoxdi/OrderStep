﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Infrastracture.Model
{
    public class Actions
    {
        [Key]
        public int ActionId { get; set; }

        /// <summary>
        /// Названия действия
        /// </summary>
        public string Name { get; set; }
    }
}
