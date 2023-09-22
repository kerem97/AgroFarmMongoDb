namespace AgroFarmMongoDb.Settings
{
    public interface IDatabaseSettings
    {
        public string AboutCollectionName { get; set; }
        public string BannerCollectionName { get; set; }
        public string WhatWeDoCollectionName { get; set; }
        public string StatisticCollectionName { get; set; }
        public string TestimonialCollectionName { get; set; }
        public string WhyUsCollectionName { get; set; }
        public string VideoPopupCollectionName { get; set; }

        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
