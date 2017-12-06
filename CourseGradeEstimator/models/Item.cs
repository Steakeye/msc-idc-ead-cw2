using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.models
{
    public abstract class Item
    {
        public static T GetInstanceFromJson<T>(string json)
            where T : Item
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        public static string GetJsonFromInstance<T>(T item)
            where T : Item
        {
            return JsonConvert.SerializeObject(item);
        }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
