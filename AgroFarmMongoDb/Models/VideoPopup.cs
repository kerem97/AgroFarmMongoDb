using MongoDB.Bson.Serialization.Attributes;

namespace AgroFarmMongoDb.Models
{
    public class VideoPopup
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string VideoPopupId { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string? VideoUrl { get; set; }
    }
}
