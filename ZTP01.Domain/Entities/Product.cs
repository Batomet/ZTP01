using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ZTP01.Domain.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Price")]
        public decimal Price { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }
    }
}