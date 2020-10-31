using Sozvezdie.DAL.Interfaces;

namespace Sozvezdie
{
    public static class AppInitializer
    {
        public static void SeedData(ITourRepository tourRepository)
        {
            var tours =  DataReader.ReadJsonFile("Data.json", "Data");

            //TODO 5 : Add data to TourRepository
            tourRepository.AddData(tours);
        }
    }
}