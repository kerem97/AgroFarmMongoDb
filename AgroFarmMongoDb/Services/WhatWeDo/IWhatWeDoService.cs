namespace AgroFarmMongoDb.Services.WhatWeDo
{
    public interface IWhatWeDoService
    {
        Task<List<Models.WhatWeDo>> GetAllWhatWeDo();

        Task<Models.WhatWeDo> GetByIdWhatWeDo(string id);

        Task CreateWhatWeDo(Models.WhatWeDo whatWeDo);

        Task UpdateWhatWeDo(Models.WhatWeDo whatWeDo);

        Task DeleteWhatWeDo(string id);
    }
}
