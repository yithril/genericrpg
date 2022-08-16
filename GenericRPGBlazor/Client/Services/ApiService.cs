using GenericRPGBlazor.Client.Services.Interface;
using System.Net.Http.Json;
using AutoWrapper.Server;

namespace GenericRPGBlazor.Client.Services
{
    public class ApiService : IApiService
    {
        private IHttpClientFactory _httpClientFactory;

        public ApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> Get<T>(string endpoint)
        {
            var httpClient = _httpClientFactory.CreateClient("GameAPI");

            var response = await httpClient.GetAsync(endpoint);

            var jsonString = await response.Content.ReadAsStringAsync();

            Console.WriteLine(jsonString);

            var returnObj = Unwrapper.Unwrap<T>(jsonString);

            return returnObj;
        }

        public async Task<T> Post<T>(string endpoint, object data)
        {
            var httpClient = _httpClientFactory.CreateClient("GameAPI");

            JsonContent content = JsonContent.Create(data);

            var response = await httpClient.PostAsync(endpoint, content);

            var jsonString = await response.Content.ReadAsStringAsync();

            var returnObj = Unwrapper.Unwrap<T>(jsonString);

            return returnObj;
        }

        public async Task<T> Put<T>(string endpoint, object data)
        {
            var httpClient = _httpClientFactory.CreateClient("GameAPI");

            JsonContent content = JsonContent.Create(data);

            var response = await httpClient.PutAsync(endpoint, content);

            var jsonString = await response.Content.ReadAsStringAsync();

            var returnObj = Unwrapper.Unwrap<T>(jsonString);

            return returnObj;
        }

        public async Task<T> Delete<T>(string endpoint)
        {
            var httpClient = _httpClientFactory.CreateClient("GameAPI");

            var response = await httpClient.DeleteAsync(endpoint);

            var jsonString = await response.Content.ReadAsStringAsync();

            var returnObj = Unwrapper.Unwrap<T>(jsonString);

            return returnObj;
        }
    }
}
