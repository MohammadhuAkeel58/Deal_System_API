namespace DealAPI.Models.DTO
{
    public class CreateDealDto
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string? Image { get; set; }

      
        public List<HotelDto> Hotels { get; set; }
    }
}
