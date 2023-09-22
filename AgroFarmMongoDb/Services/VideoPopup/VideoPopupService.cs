using AgroFarmMongoDb.Settings;
using MongoDB.Driver;

namespace AgroFarmMongoDb.Services.VideoPopup
{
    public class VideoPopupService : IVideoPopupService
    {
        private readonly IMongoCollection<Models.VideoPopup> _videoPopupCollection;

        public VideoPopupService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _videoPopupCollection = database.GetCollection<Models.VideoPopup>(_databaseSettings.VideoPopupCollectionName);
        }
        public async Task CreateVideoPopup(Models.VideoPopup videoPopup)
        {
            await _videoPopupCollection.InsertOneAsync(videoPopup);
        }

        public async Task DeleteVideoPopup(string id)
        {
            await _videoPopupCollection.DeleteOneAsync(x => x.VideoPopupId == id);
        }

        public async Task<List<Models.VideoPopup>> GetAllVideoPopup()
        {
            var values = await _videoPopupCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Models.VideoPopup> GetByIdVideoPopup(string id)
        {
            var value = await _videoPopupCollection.Find(x => x.VideoPopupId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateVideoPopup(Models.VideoPopup videoPopup)
        {
            await _videoPopupCollection.FindOneAndReplaceAsync(x => x.VideoPopupId == videoPopup.VideoPopupId, videoPopup);
        }
    }
}
