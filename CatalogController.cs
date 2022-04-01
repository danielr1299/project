using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShop.Data.Contexts;
using PetShop.Data.Models;
using PetShop.Data.Repositories;
using System;

namespace PetShop.Client.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IRepository<Category> _repo;
        private readonly IAnimalRepository _repoAni;
        private readonly PetShopDbContext _db;

        public CatalogController
            (IRepository<Category> repo,
            IAnimalRepository repoAni,
            PetShopDbContext db)
        {
            _repo = repo;
            _repoAni = repoAni;
            _db = db;
            
        }

        
        public IActionResult DisplayAnimals()
        {
            //ViewBag.CategoryId = new SelectList(_repo.Get(), "CategoryId", "Name");
            return View(_repo.Get());
        }

        public IActionResult ShowAnimal(int animel)
        {
            ViewBag.Selected = animel;
            Animal ani = _repoAni.GetAnimals(animel);
            return View(ani);
        }

















        //public IActionResult GetSearchingData(string SearchBy,string SearchValue)
        //{
        //    List<Animal> animalList = new();
        //    if(SearchBy == "ID")
        //    {
        //        try
        //        {
        //            int id = Convert.ToInt32(SearchValue);
        //            animalList = _db.Animals.Where(x => x.AnimalId == id || SearchValue == null).ToList();
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("{0} is Not A ID",SearchValue);
        //        }
        //        return Json(animalList);
        //    }
        //    else
        //    {
        //        animalList = _db.Animals.Where(x => x.Name.StartsWith(SearchValue)
        //        || SearchValue == null).ToList();
        //        return Json(animalList);
        //    }
        //}
    }
}
