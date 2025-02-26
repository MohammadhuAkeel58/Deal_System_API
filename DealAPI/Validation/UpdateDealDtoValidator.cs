using DealAPI.Models.DTO;
using FluentValidation;

namespace DealAPI.Validation
{
    public class UpdateDealDtoValidator: AbstractValidator<UpdateDealDto>
    {
        public UpdateDealDtoValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name cannot be longer than 100 characters.");

            RuleFor(x => x.Slug)
                .NotEmpty().WithMessage("Slug is required.")
                .MaximumLength(100).WithMessage("Slug cannot be longer than 100 characters.");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(200).WithMessage("Title cannot be longer than 200 characters.");

            RuleFor(x => x.Image)
                .Matches(@"^.*\.(jpg|jpeg|png|gif|bmp)$").WithMessage("Invalid image format. Please upload a valid image.");
        }
    }
}
