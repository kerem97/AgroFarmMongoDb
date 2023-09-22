using MongoDB.Bson.Serialization.Attributes;

namespace AgroFarmMongoDb.Models
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string TestimonialId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
    }
}

