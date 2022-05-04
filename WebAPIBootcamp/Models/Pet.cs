namespace WebAPIBootcamp.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Breed { get; set; }
    }
    public class ViewModelPet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Breed { get; set; }
    }
}
