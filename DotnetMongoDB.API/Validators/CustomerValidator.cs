using DotnetMongoDB.API.Models;
using FluentValidation;

namespace DotnetMongoDB.API.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Name).Length(20, 250);
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Please specify a phone number.");
            RuleFor(x => x.Age).InclusiveBetween(18, 60);

            // Complex Properties
            RuleFor(x => x.Address).InjectValidator();

            // Other way
            //RuleFor(x => x.Address).SetValidator(new AddressValidator());

            // Collections of Complex Types
            //RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());
        }
    }
}
