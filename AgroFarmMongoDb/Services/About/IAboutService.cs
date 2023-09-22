﻿namespace AgroFarmMongoDb.Services.About
{
    public interface IAboutService
    {
        Task<List<Models.About>> GetAllAbout();

        Task<Models.About> GetByIdAbout();

        Task CreateAbout(Models.About about);

        Task UpdateAbout(Models.About about);

        Task DeleteAbout(string id);
    }
}
