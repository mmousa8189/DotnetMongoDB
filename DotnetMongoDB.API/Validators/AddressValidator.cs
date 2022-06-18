using DotnetMongoDB.API.Models;
using FluentValidation;

namespace DotnetMongoDB.API.Validators
{
    public class AddressValidator : AbstractValidator<AddressModel>
    {
        public AddressValidator()
        {
            RuleFor(x => x.State).NotNull().NotEmpty();
            RuleFor(x => x.Country).NotEmpty().WithMessage("Please specify a Country.");

            RuleFor(x => x.Postcode).NotNull();
            RuleFor(x => x.Postcode).Must(BeAValidPostcode).WithMessage("Please specify a valid postcode");
        }

        private bool BeAValidPostcode(string postcode)
        {
            // custom postcode validating logic goes here.

            return true;
        }
    }
}
