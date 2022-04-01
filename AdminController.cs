using Microsoft.AspNetCore.Mvc;
using PetShop.Client.Models;
using PetShop.Data.Repositories;

namespace PetShop.Client.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAnimalRepository _repo;

        public AdminController(IAnimalRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Manager()
        {
            return CreateAnimal();
        }

        [HttpGet()]
        public IActionResult CreateAnimal()
        {
            return View();
        }


        [HttpPost("Create")]
        public async Task<IActionResult> CreateAnimal1([FromForm] CreateAnimalViewModel model)
        {
            var path = Path.Combine(Environment.CurrentDirectory,"Images");
            Directory.CreateDirectory(path);
            path = Path.Combine(path, model.Photo!.FileName);
            if (model.Photo.Length > 0)
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await model.Photo.CopyToAsync(stream);
                }
            }

            model.Animal!.PhotoUrl = path;
            _repo.Add(model.Animal);

            return View();
        }
    }
}
