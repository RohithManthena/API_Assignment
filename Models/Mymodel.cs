﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Assignment.Models
{
    public class Mymodel
    {
        public string finalfood { get; set; }
        public string description { get; set; }
        public List<FoodNutrients> foodNutrients { get; set; }
    }
}
