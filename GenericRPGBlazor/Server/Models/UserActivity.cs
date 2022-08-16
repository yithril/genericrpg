using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Server.Models
{
    public class UserActivity : EntityBase
    {
        public string AuthId { get; set; }
        public ActivityType ActivityType { get; set; }
    }
}
