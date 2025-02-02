using Microsoft.EntityFrameworkCore;
using W67652MaksymilianLechowiczProjektZAplikacjiWebowych.Entity;
namespace W67652MaksymilianLechowiczProjektZAplikacjiWebowych.Services
{
    public class CrossService: ICrossService
    {
        private readonly CrossDbContext _crossService;
        public CrossService(CrossDbContext context)
        {
            _crossService = context;
        }
        public async Task<List<Plant>> GetPlants()
        {
            return await _crossService.Plants.ToListAsync();
        }

        public async Task<Plant> GetPlant(int id)
        {
            var plant = await _crossService.Plants.FindAsync(id);
            if (plant == null)
            {
                throw new Exception("plant not found");
            }
            return plant;
        }

        public async Task AddPlant(Plant plant)
        {
            if(plant.PlantName is not null){
            _crossService.Plants.Add(plant);
            await _crossService.SaveChangesAsync();
            }
        }

        public async Task UpdatePlant(Plant plant)
        {
            if(plant.PlantName is not null){
            _crossService.Entry(plant).State = EntityState.Modified;
            await _crossService.SaveChangesAsync();
            }
        }

        public async Task DeletePlant(int id)
        {
            var plant = await _crossService.Plants.FindAsync(id);
            if (plant != null)
            {
                _crossService.Plants.Remove(plant);
                await _crossService.SaveChangesAsync();
            }
        }
    
}
}
