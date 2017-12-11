﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.models
{
    public abstract class CourseItem : Item
    {
        [JsonProperty("description")]
        public string Description;
    }
}
