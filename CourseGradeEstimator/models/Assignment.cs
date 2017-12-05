using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.models
{
    public class Course : CourseItem
    {
        public int TotalCredits { get => determineCredits(); }

        [JsonProperty("modules")]
        public List<Module> Modules;

        private int determineCredits() {
            return 42;
        }
    }
}
