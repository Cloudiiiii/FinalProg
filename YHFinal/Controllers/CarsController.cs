using Microsoft.AspNetCore.Mvc;
using YHFinal.Models;
using YHFinal.Services;
using System.Linq;

namespace YHFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly JsonFileService _fileService;

        public CarsController()
        {
            _fileService = new JsonFileService();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_fileService.ReadCars());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cars = _fileService.ReadCars();
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return NotFound();
            return Ok(car);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] Car newCar)
        {
            var cars = _fileService.ReadCars();
            if (cars == null)
            {
                cars = new List<Car>();
            }
            newCar.Id = cars.Any() ? cars.Max(c => c.Id) + 1 : 1;
            cars.Add(newCar);
            _fileService.WriteCars(cars);
            return CreatedAtAction(nameof(GetById), new { id = newCar.Id }, newCar);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Car updatedCar)
        {
            var cars = _fileService.ReadCars();
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return NotFound();

            car.Make = updatedCar.Make;
            car.Model = updatedCar.Model;
            car.Year = updatedCar.Year;
            _fileService.WriteCars(cars);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cars = _fileService.ReadCars();
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return NotFound();

            cars.Remove(car);
            _fileService.WriteCars(cars);
            return NoContent();
        }
    }
}
