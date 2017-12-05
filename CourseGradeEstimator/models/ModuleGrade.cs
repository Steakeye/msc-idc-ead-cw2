using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.models
{
    public class ModuleGrade : GradeItem
    {
        [JsonProperty("assignments")]
        public List<AssignmentGrade> Assignments;

    }
}
