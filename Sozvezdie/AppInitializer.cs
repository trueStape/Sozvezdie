using Sozvezdie.DAL.Interfaces;

namespace Sozvezdie
{
    public static class AppInitializer
    {
        public static void SeedData(ITourRepository tourRepository)
        {
            var tours =  DataReader.ReadJsonFile("Data.json", "Data");

            //TODO 5 : add data to TourRepository
            foreach (var tour in tours)
            {
                
            }
        }
    }
}