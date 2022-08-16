using GenericRPGBlazor.Server.Models;

namespace GenericRPGBlazor.Server.Services.Interface
{
    public interface IUserActivityService
    {
        Task<UserActivity> PostActivity(UserActivity activity);
    }
}
