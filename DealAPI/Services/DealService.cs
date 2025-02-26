using DealAPI.Data;
using DealAPI.Models.Domain;
using DealAPI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DealAPI.Services
{
    public class DealService : IDealService
    {
        private readonly DealsDbContext context;

        public DealService(DealsDbContext context)
        {
            this.context = context;
        }

        public async Task<DealDto> CreateDealAsync(CreateDealDto createDealDto)
        {
            var deal = new Deal
            {
                Name = createDealDto.Name,
                Slug = createDealDto.Slug,
                Title = createDealDto.Title,
                Image = createDealDto.Image
            };

            if (createDealDto.Hotels != null && createDealDto.Hotels.Any())
            {
                var hotels = createDealDto.Hotels.Select(hotelDto => new Hotel
                {
                    Name = hotelDto.Name,
                    Location = hotelDto.Location,
                    Description = hotelDto.Description
                }).ToList();

                deal.Hotels = hotels;
            }

            context.Deals.Add(deal);
            await context.SaveChangesAsync();

            return new DealDto
            {
                Id = deal.Id,
                Name = deal.Name,
                Slug = deal.Slug,
                Title = deal.Title,
                Image = deal.Image,
                Hotels = deal.Hotels?.Select(h => new HotelDto
                {
                    HotelId = h.HotelId,
                    Name = h.Name,
                    Location = h.Location,
                    Description = h.Description
                }).ToList()
            };
        }

        public async Task<DealDto> GetDealByIdAsync(Guid id)
        {
            var deal = await context.Deals.Include(d => d.Hotels).FirstOrDefaultAsync(d => d.Id == id);
            if (deal == null) return null;

            return new DealDto
            {
                Id = deal.Id,
                Name = deal.Name,
                Slug = deal.Slug,
                Title = deal.Title,
                Image = deal.Image,
                Hotels = deal.Hotels.Select(h => new HotelDto
                {
                    HotelId = h.HotelId,
                    Name = h.Name,
                    Location = h.Location,
                    Description = h.Description
                }).ToList()
            };
        }

        public async Task<IEnumerable<DealDto>> GetAllDealsAsync()
        {
            var deals = await context.Deals.Include(d => d.Hotels).ToListAsync();
            return deals.Select(d => new DealDto
            {
                Id = d.Id,
                Name = d.Name,
                Slug = d.Slug,
                Title = d.Title,
                Image = d.Image,
                Hotels = d.Hotels.Select(h => new HotelDto
                {
                    HotelId = h.HotelId,
                    Name = h.Name,
                    Location = h.Location,
                    Description = h.Description
                }).ToList()
            });
        }

        public async Task<DealDto> UpdateDealAsync(Guid id, UpdateDealDto updateDealDto)
        {
            var deal = await context.Deals.FindAsync(id);
            if (deal == null) return null;

            deal.Name = updateDealDto.Name;
            deal.Slug = updateDealDto.Slug;
            deal.Title = updateDealDto.Title;
            deal.Image = updateDealDto.Image;
            

            context.Deals.Update(deal);
            await context.SaveChangesAsync();

            return new DealDto
            {
                Id = deal.Id,
                Name = deal.Name,
                Slug = deal.Slug,
                Title = deal.Title,
                Image = deal.Image
            };
        }

        public async Task DeleteDealAsync(Guid id)
        {
            var deal = await context.Deals.FindAsync(id);
            if (deal == null) return;

            context.Deals.Remove(deal);
            await context.SaveChangesAsync();
        }
    }
}
