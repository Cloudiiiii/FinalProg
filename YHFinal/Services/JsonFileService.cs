using Newtonsoft.Json;
using YHFinal.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace YHFinal.Services
{
    public class JsonFileService
    {
        private readonly string _filePath = "cars.json";

        public List<Car> ReadCars()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]");
            }
            return JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(_filePath));
        }

        public void WriteCars(List<Car> cars)
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(cars, Formatting.Indented));
        }
    }
    
}
