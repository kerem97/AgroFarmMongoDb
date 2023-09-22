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

        public Task CreateAbout(Models.About about)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAbout(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Models.About>> GetAllAbout()
        {
            throw new NotImplementedException();
        }

        public Task<Models.About> GetByIdAbout()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAbout(Models.About about)
        {
            throw new NotImplementedException();
        }
    }
}
