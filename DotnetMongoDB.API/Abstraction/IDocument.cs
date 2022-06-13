using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DotnetMongoDB.API.Abstraction
{
    /// <summary>
    /// creating proper abstraction layer for our documents (entities in Mongo).
    /// contains base information about each document
    /// </summary>
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreatedAt { get; }
    }
}
