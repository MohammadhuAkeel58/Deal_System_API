using DealAPI.Models.Domain;

namespace DealAPI.Models.DTO
{
    public class HotelDto
    {

       
        
        public Guid HotelId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        
    }
}
