using System;
using Newtonsoft.Json;

namespace SpaceX.Api.Client.Models.Company
{
    public class CompanyHistory
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("event_date_utc")]
        public DateTimeOffset EventDateUtc { get; set; }

        [JsonProperty("event_date_unix")]
        public long EventDateUnix { get; set; }

        [JsonProperty("flight_number")]
        public long? FlightNumber { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Links
    {
        [JsonProperty("reddit")]
        public string Reddit { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }
}
