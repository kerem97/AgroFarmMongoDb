using MongoDB.Bson.Serialization.Attributes;

namespace AgroFarmMongoDb.Models
{
    public class Banner
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int BannerId { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
    }
}
