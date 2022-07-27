using GenericRPGBlazor.Client.Services.Interface;
using System.Net.Http.Json;

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
            return await _httpClient.GetFromJsonAsync<T>(endpoint);
        }

        public async Task<T> Post<T>(string endpoint, object data)
        {
            var response = await _httpClient.PostAsJsonAsync(endpoint, data);

            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> Put<T>(string endpoint, object data)
        {
            var response = await _httpClient.PutAsJsonAsync(endpoint, data);

            return await response.Content.ReadFromJsonAsync<T>();
        }

        public async Task<T> Delete<T>(string endpoint)
        {
            var response = await _httpClient.DeleteAsync(endpoint);

            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}
