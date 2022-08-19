using MongoDB.Bson.Serialization.Attributes;

namespace BlazorMongoApp.Models
{
    [BsonIgnoreExtraElements]
    public class Order
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
        public string CustomerName { get; set; }
        public string Freight { get; set; }
        public string ShipCountry { get; set; }
    }
}
