namespace GenericRPGBlazor.Client.Services.Interface
{
    public interface IApiService
    {
        Task<T> Get<T>(string endpoint);
        Task<T> Post<T>(string endpoint, object data);
        Task<T> Put<T>(string endpoint, object data);
        Task<T> Delete<T>(string endpoint);
    }
}
