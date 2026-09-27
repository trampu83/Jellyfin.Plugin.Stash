using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stash.Helpers;

namespace Stash.Models
{
    public struct Performer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        [JsonProperty(PropertyName = "disambiguation")]
        public string Disambiguation { get; set; }

        [JsonProperty(PropertyName = "image_path")]
        public string ImagePath { get; set; }

        [JsonProperty(PropertyName = "alias_list")]
        public List<string> AliasList { get; set; }

        [JsonProperty(PropertyName = "birthdate")]
        [JsonConverter(typeof(FuzzyDateConverter))]
        public DateTime? BirthDate { get; set; }

        [JsonProperty(PropertyName = "death_date")]
        [JsonConverter(typeof(FuzzyDateConverter))]
        public DateTime? DeathDate { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<Tags> Tags { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}
