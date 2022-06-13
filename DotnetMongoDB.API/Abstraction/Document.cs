using MongoDB.Bson;
using System;

namespace DotnetMongoDB.API.Abstraction
{
    /// <summary>
    /// creating proper abstraction layer for our documents (entities in Mongo).
    /// contains base information about each document
    /// </summary>
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
