using DealAPI.Models.DTO;

namespace DealAPI.Services
{
    public interface IDealService
    {
        Task<DealDto> CreateDealAsync(CreateDealDto createDealDto);
        Task<DealDto> GetDealByIdAsync(Guid id);
        Task<IEnumerable<DealDto>> GetAllDealsAsync();
        Task<DealDto> UpdateDealAsync(Guid id, UpdateDealDto updateDealDto);
        Task DeleteDealAsync(Guid id);
    }
}
