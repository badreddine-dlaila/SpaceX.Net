using System;
using System.Threading.Tasks;
using RestSharp;
using SpaceX.Api.Client.Models.Company;

namespace SpaceX.Api.Client
{
    public class SpaceXClient : ISpaceXClient
    {
        private readonly IRestClient _restClient;
        public SpaceXClient(IRestClient restClient)
        {
            _restClient = restClient;
            _restClient.BaseUrl = new Uri("https://api.spacexdata.com/v2/");

        }

        public async Task<CompanyInfo> GetCompanyInfo()
        {
            var request = new RestRequest
            {
                Resource = "info",
                Method =  Method.GET
            };
            var response = await _restClient.ExecuteTaskAsync<CompanyInfo>(request);

            return response.Data;
        }

        public async Task<CompanyHistory> GetCompanyHistory()
        {
            var request = new RestRequest
            {
                Resource = "history",
                Method = Method.GET
            };
            var response = await _restClient.ExecuteTaskAsync<CompanyHistory>(request);

            return response.Data;
        }
    }
}
