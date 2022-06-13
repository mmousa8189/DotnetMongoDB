using DotnetMongoDB.API.Abstraction;
using DotnetMongoDB.API.Settings;
using System;

namespace DotnetMongoDB.API.Models
{
    [BsonCollection("people")]
    public class Person : Document
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
