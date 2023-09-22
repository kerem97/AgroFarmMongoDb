using MongoDB.Bson.Serialization.Attributes;

namespace AgroFarmMongoDb.Models
{
    public class WhatWeDo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string WhatWeDoId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

    }
}
