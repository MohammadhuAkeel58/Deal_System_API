using DealAPI.Models.DTO;
using DealAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DealAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealsController : ControllerBase
    {
        private readonly IDealService dealService;

        public DealsController(IDealService dealService)
        {
            
            this.dealService = dealService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeal([FromBody] CreateDealDto createDealDto)
        {
           
            var deal = await dealService.CreateDealAsync(createDealDto);
            return CreatedAtAction(nameof(GetDealById), new { id = deal.Id }, deal);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDealById(Guid id)
        {
            var deal = await dealService.GetDealByIdAsync(id);
            if (deal == null)
            {
                return NotFound();
            }

            return Ok(deal);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDeals()
        {
            var deals = await dealService.GetAllDealsAsync();
            return Ok(deals);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeal(Guid id)
        {
            await dealService.DeleteDealAsync(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDeal(Guid id, [FromBody] UpdateDealDto updateDealDto)
        {
            var updatedDeal = await dealService.UpdateDealAsync(id, updateDealDto);
            if (updatedDeal == null)
            {
                return NotFound();
            }

            return Ok(updatedDeal);
        }
    }
}
