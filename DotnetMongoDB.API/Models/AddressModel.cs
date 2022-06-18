using DotnetMongoDB.API.Abstraction;
using DotnetMongoDB.API.Settings;

namespace DotnetMongoDB.API.Models
{
    [BsonCollection("Addresses")]
    public class AddressModel : Document
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
    }
}
