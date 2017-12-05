using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.models
{
    public class AssignmentGrade : GradeItem
    {
        [JsonProperty("score")]
        public int Score;
    }
}
