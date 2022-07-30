using GenericRPGBlazor.Client.Services.Interface;
using System.Net.Http.Json;
using AutoWrapper.Server;

namespace GenericRPGBlazor.Client.Services
{
    public class ApiService : IApiService
    {
        private HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> Get<T>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);

            var jsonString = await response.Content.ReadAsStringAsync();

            var returnObj = Unwrapper.Unwrap<T>(jsonString);

            return returnObj;
        }

        public async Task<T> Post<T>(string endpoint, object data)
        {
            JsonContent content = JsonContent.Create(data);

            var response = await _httpClient.PostAsync(endpoint, content);

            var jsonString = await response.Content.ReadAsStringAsync();

            var returnObj = Unwrapper.Unwrap<T>(jsonString);

            return returnObj;
        }

        public async Task<T> Put<T>(string endpoint, object data)
        {
            JsonContent content = JsonContent.Create(data);

            var response = await _httpClient.PutAsync(endpoint, content);

            var jsonString = await response.Content.ReadAsStringAsync();

            var returnObj = Unwrapper.Unwrap<T>(jsonString);

            return returnObj;
        }

        public async Task<T> Delete<T>(string endpoint)
        {

            var response = await _httpClient.DeleteAsync(endpoint);

            var jsonString = await response.Content.ReadAsStringAsync();

            var returnObj = Unwrapper.Unwrap<T>(jsonString);

            return returnObj;
        }
    }
}
