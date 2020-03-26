﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Models
{
    public class ToDoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool isComplete { get; set; }
        public string Secret { get; set; }
    }
}
