﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm_EfCore_Final_Project.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderCount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}