using DealAPI.Models.Domain;


namespace DealAPI.Models.Domain
{
    public class Hotel
    {
        public Guid HotelId { get; set; }  
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

       
        public Guid DealId { get; set; }  

      
        public Deal Deal { get; set; }    
    }
}
