using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDbGenericRepository.Attributes;

namespace backend.Models
{
    [CollectionName("Product")] // MongoDB collection name

    public class Product
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id {get;set;}

        [BsonElement("name")]
        public string ProductName {get;set;}

        [BsonElement("Price")]
        public double ProductPrice {get;set;}

        [BsonElement("description")]
        public string ProductDescription {get;set;}

        [BsonElement("imageUrl")]
        public string ImageUrl {get;set;}

        [BsonElement("createdAt")]
        public DateTime CreatedAt {get;} // Create a Timestamp - immutable (only uses the getter)

        // constructor to initialize CreatedAt
        public Product()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
