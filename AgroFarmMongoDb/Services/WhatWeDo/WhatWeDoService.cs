using AgroFarmMongoDb.Settings;
using MongoDB.Driver;

namespace AgroFarmMongoDb.Services.WhatWeDo
{
    public class WhatWeDoService : IWhatWeDoService
    {
        private readonly IMongoCollection<Models.WhatWeDo> _whatWeDoCollection;

        public WhatWeDoService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _whatWeDoCollection = database.GetCollection<Models.WhatWeDo>(_databaseSettings.WhatWeDoCollectionName);
        }
        public async Task CreateWhatWeDo(Models.WhatWeDo whatWeDo)
        {
            await _whatWeDoCollection.InsertOneAsync(whatWeDo);
        }

        public async Task DeleteWhatWeDo(string id)
        {
            await _whatWeDoCollection.DeleteOneAsync(x => x.WhatWeDoId == id);
        }

        public async Task<List<Models.WhatWeDo>> GetAllWhatWeDo()
        {
            var values = await _whatWeDoCollection.Find(x => true).ToListAsync();
            return values;
        }

        public async Task<Models.WhatWeDo> GetByIdWhatWeDo(string id)
        {
            var value = await _whatWeDoCollection.Find(x => x.WhatWeDoId == id).FirstOrDefaultAsync();
            return value;
        }

        public async Task UpdateWhatWeDo(Models.WhatWeDo whatWeDo)
        {
            await _whatWeDoCollection.FindOneAndReplaceAsync(x => x.WhatWeDoId == whatWeDo.WhatWeDoId, whatWeDo);
        }
    }
}
