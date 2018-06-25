using Newtonsoft.Json;

namespace SpaceX.Api.Client.Models.Company
{
    public class CompanyInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("founder")]
        public string Founder { get; set; }

        [JsonProperty("founded")]
        public long Founded { get; set; }

        [JsonProperty("employees")]
        public long Employees { get; set; }

        [JsonProperty("vehicles")]
        public long Vehicles { get; set; }

        [JsonProperty("launch_sites")]
        public long LaunchSites { get; set; }

        [JsonProperty("test_sites")]
        public long TestSites { get; set; }

        [JsonProperty("ceo")]
        public string Ceo { get; set; }

        [JsonProperty("cto")]
        public string Cto { get; set; }

        [JsonProperty("coo")]
        public string Coo { get; set; }

        [JsonProperty("cto_propulsion")]
        public string CtoPropulsion { get; set; }

        [JsonProperty("valuation")]
        public long Valuation { get; set; }

        [JsonProperty("headquarters")]
        public Headquarters Headquarters { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class Headquarters
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}
