using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.models
{
    public class Module : CourseItem
    {
        [JsonProperty("year")]
        public int Year;

        [JsonProperty("assignments")]
        public List<Assignment> Assignments;

        public int Credits { get => determineCredits(); }

        private int determineCredits()
        {
            return 42;
        }
    }
}
