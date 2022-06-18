using DotnetMongoDB.API.Abstraction;
using DotnetMongoDB.API.Settings;

namespace DotnetMongoDB.API.Models
{
    [BsonCollection("Customers")]
    public class CustomerModel: Document
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAdult { get; set; }

        public AddressModel Address { get; set; }
    }
}
