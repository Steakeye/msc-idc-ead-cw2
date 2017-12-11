using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.models
{
    public class Assignment : CourseItem
    {
        [JsonProperty("modules")]
        public int CreditWeight;
        
        [JsonProperty("qualifying_component")]
        public int QualifyingComponent;
    }
}
