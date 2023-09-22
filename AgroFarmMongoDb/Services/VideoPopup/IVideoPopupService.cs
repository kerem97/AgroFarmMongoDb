namespace AgroFarmMongoDb.Services.VideoPopup
{
    public interface IVideoPopupService
    {
        Task<List<Models.VideoPopup>> GetAllVideoPopup();

        Task<Models.VideoPopup> GetByIdVideoPopup(string id);

        Task CreateVideoPopup(Models.VideoPopup videoPopup);

        Task UpdateVideoPopup(Models.VideoPopup videoPopup);

        Task DeleteVideoPopup(string id);
    }
}
