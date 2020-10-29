using Newtonsoft.Json;
using Sozvezdie.BLL.Models;
using System.Collections.Generic;
using System.IO;
using Sozvezdie.DAL.Models;

namespace Sozvezdie
{
    public static class DataReader
    {
        public static IEnumerable<Tour> ReadJsonFile(string fileName, string location)
        {
            string root = "wwwroot";

            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                root,
                location,
                fileName);

            // read file into a string and deserialize JSON to a type
            return JsonConvert.DeserializeObject<IEnumerable<Tour>>(File.ReadAllText(path));
        }
    }
}