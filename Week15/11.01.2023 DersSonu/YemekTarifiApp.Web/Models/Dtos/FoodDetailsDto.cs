using YemekTarifiApp.Entity;

namespace YemekTarifiApp.Web.Models.Dtos
{
    public class FoodDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int Point { get; set; }
        public List<Category> Categories { get; set; }

    }
}
