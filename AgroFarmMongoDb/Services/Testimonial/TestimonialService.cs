using AgroFarmMongoDb.Settings;
using MongoDB.Driver;

namespace AgroFarmMongoDb.Services.Testimonial
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IMongoCollection<Models.Testimonial> _testimonialCollection;

        public TestimonialService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _testimonialCollection = database.GetCollection<Models.Testimonial>(_databaseSettings.TestimonialCollectionName);
        }
        public async Task CreateTestimonial(Models.Testimonial testimonial)
        {
            await _testimonialCollection.InsertOneAsync(testimonial);
        }

        public async Task DeleteTestimonial(string id)
        {
            await _testimonialCollection.DeleteOneAsync(x => x.TestimonialId == id);
        }

        public async Task<List<Models.Testimonial>> GetAllTestimonial()
        {
            var values = await _testimonialCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Models.Testimonial> GetByIdTestimonial(string id)
        {
            var value = await _testimonialCollection.Find(x => x.TestimonialId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateTestimonial(Models.Testimonial testimonial)
        {
            await _testimonialCollection.FindOneAndReplaceAsync(x => x.TestimonialId == testimonial.TestimonialId, testimonial);
        }
    }
}
