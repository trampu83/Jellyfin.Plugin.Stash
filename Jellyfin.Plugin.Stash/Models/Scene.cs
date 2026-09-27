using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stash.Helpers;

namespace Stash.Models
{
    public struct Scene
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(FuzzyDateConverter))]
        public DateTime? Date { get; set; }

        [JsonProperty(PropertyName = "rating100")]
        public int? Rating100 { get; set; }

        [JsonProperty(PropertyName = "paths")]
        public Paths Paths { get; set; }

        [JsonProperty(PropertyName = "studio")]
        public Studio? Studio { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<Tags> Tags { get; set; }

        [JsonProperty(PropertyName = "performers")]
        public List<Performer> Performers { get; set; }
    }
}
