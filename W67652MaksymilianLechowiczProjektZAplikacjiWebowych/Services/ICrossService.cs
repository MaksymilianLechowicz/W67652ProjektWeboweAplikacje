using W67652MaksymilianLechowiczProjektZAplikacjiWebowych.Entity;
namespace W67652MaksymilianLechowiczProjektZAplikacjiWebowych.Services
{
    public interface ICrossService
    {
        Task<List<Plant>> GetPlants();
        Task<Plant> GetPlant(int id);
        Task AddPlant(Plant plant);
        Task UpdatePlant(Plant plant);
        Task DeletePlant(int id);
    }
}
