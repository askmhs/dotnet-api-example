using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_rest_api.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; }

        public int Price { get; set; }

        public string Author { get; set; }
    }
}
