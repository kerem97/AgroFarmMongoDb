﻿using MongoDB.Bson.Serialization.Attributes;

namespace AgroFarmMongoDb.Models
{
    public class Statistic
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string StatisticId { get; set; }

        public string Title { get; set; }
        public string Icon { get; set; }
        public int Count { get; set; }

        public string Description { get; set; }
    }
}
