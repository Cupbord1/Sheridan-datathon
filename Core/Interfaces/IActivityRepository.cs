using Carbon.Core.Entities;

namespace Carbon.Core.Interfaces;

public interface IActivityRepository
{
    Task<Activity> AddAsync(Activity activity);
    Task<IEnumerable<Activity>> GetByUserAsync(string userId);
    Task<Activity?> GetAsync(int id, string userId);
    Task UpdateAsync(Activity activity);
    Task DeleteAsync(Activity activity);
}