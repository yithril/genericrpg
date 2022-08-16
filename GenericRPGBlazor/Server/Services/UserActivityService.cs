using AutoMapper;
using GenericRPGBlazor.Server.Data;
using GenericRPGBlazor.Server.Models;
using GenericRPGBlazor.Server.Services.Interface;
using GenericRPGBlazor.Shared.Enum;

namespace GenericRPGBlazor.Server.Services
{
    public class UserActivityService : IUserActivityService
    {
        private readonly GameDbContext _context;
        private readonly IMapper _mapper;

        public UserActivityService(GameDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserActivity> PostActivity(UserActivity activity)
        {
            await _context.UserActivities.AddAsync(activity);

            return activity;
        }
    }
}
