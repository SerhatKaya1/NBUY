using YemekTarifiApp.Entity.Concrate;

namespace YemekTarifiApp.Web.Models.Dtos
{
    public class RepiceDetails
    {
        public string Id { get; set; }
        public string RecipeMaking { get; set; }
        public string Owner { get; set; }
        public string OwnerMail { get; set; }
        public List<Food> Foods { get; set; }
       
    }
}
