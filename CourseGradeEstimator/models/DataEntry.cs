using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGradeEstimator.models
{
    public class DataEntry<D>
        where D : Item
    {
        public static DataEntry<D> GetInstanceFromJson(string json)
        {
            return JsonConvert.DeserializeObject<DataEntry<D>>(json, getSerialisationSettings());
        }
        public static string GetJsonFromInstance(DataEntry<D> item)
        {
            return JsonConvert.SerializeObject(item, getSerialisationSettings());
        }

        public DataEntry(string userId, D dataItem) {
            User = userId;
            Data = dataItem;
        }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("data")]
        public D Data { get; set; }

        private static JsonSerializerSettings getSerialisationSettings()
        {
            return new JsonSerializerSettings {
                NullValueHandling = NullValueHandling.Ignore
            };
        }
    }
}
