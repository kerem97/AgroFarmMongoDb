using AgroFarmMongoDb.Settings;
using MongoDB.Driver;

namespace AgroFarmMongoDb.Services.About
{
    public class AboutService : IAboutService
    {
        private readonly IMongoCollection<Models.About> _aboutCollection;

        public AboutService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _aboutCollection = database.GetCollection<Models.About>(_databaseSettings.AboutCollectionName);
        }

        public async Task CreateAbout(Models.About about)
        {
            await _aboutCollection.InsertOneAsync(about);
        }

        public async Task DeleteAbout(string id)
        {
            await _aboutCollection.DeleteOneAsync(x => x.AboutId == id);
        }

        public async Task<List<Models.About>> GetAllAbout()
        {
            var values = await _aboutCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Models.About> GetByIdAbout(string id)
        {
            var value = await _aboutCollection.Find(x => x.AboutId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateAbout(Models.About about)
        {
            var value = await _aboutCollection.FindOneAndReplaceAsync(x => x.AboutId == about.AboutId, about);

        }
    }
}
