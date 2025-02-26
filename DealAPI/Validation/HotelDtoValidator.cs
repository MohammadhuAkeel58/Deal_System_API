using DealAPI.Models.DTO;
using FluentValidation;

namespace DealAPI.Validation
{
    public class HotelDtoValidator: AbstractValidator<HotelDto>
    {
        public HotelDtoValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Hotel name is required.")
            .MaximumLength(100).WithMessage("Hotel name cannot be longer than 100 characters.");

            RuleFor(x => x.Location)
                .NotEmpty().WithMessage("Location is required.")
                .MaximumLength(100).WithMessage("Location cannot be longer than 100 characters.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(500).WithMessage("Description cannot be longer than 500 characters.");
        }
    }
    
}
