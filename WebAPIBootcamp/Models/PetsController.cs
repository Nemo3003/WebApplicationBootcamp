using Microsoft.AspNetCore.Mvc;
using WebAPIBootcamp.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIBootcamp.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        public static List<Pet> Pets = new List<Pet>()
        {
            new Pet() { Name = "Perro", Type = "Dog", Breed = "rotty"},
            new Pet() { Name = "Gato", Type= "Cat", Breed = "Siames"}
        };
        
        // GET: api/<PetsController>
        [HttpGet]
        public IEnumerable<Pet> Get()
        {
        return Pets;
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]
        public Pet Get(int id, IEnumerable<Pet> pets)
        {
            return Pets.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] ViewModelPet vmPet)
        {
            Pet pet = new Pet()
            {
                Id = Pets.Max(x => x.Id) + 1;
                Name = vmPet.Name;
                Type = vmPet.Type;
                Breed = vmPet.Breed;
        };
        Pets.Add(pet);
            

        };

    // PUT api/<PetsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] ViewModelPet vmPet)
    {
        Pet oldPet = Pets.FirstOrDefault(X => x.Id == id);
        int pind = Pets.IndexOf(oldPet);
        if (oldPet != null)
        {
            oldPet.Breed = vmPet.Breed;
            oldPet.Name = vmPet.Name;
            oldPet.Type = vmPet.Type;

            Pets.RemoveAt(pind);
            Pets.Insert(pind, oldPet);
        };
    }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        Pet pet = Pets.FirstOrDefault(X => x.Id == id);
        if(pet != null)
        {
            Pets.Remove(id);
        }
    }
    }
}
