using System.Collections.Generic;
using Newtonsoft.Json;

namespace HealthMedicalRecords
{
    public class AutoCompleteSimplified
    {
        public IList<Prediction>? Predictions { get; set; }
    }

    public class Prediction
    {
        public string? Description { get; set; }

        [JsonProperty(PropertyName = "place_id")]
        public string? PlaceId { get; set; }
    }
}
