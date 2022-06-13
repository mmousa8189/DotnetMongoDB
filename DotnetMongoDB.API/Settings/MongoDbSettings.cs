using DotnetMongoDB.API.Contracts;

namespace DotnetMongoDB.API.Settings
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
