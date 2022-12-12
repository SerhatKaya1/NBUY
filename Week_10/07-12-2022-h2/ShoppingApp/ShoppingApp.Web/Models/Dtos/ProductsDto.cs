namespace ShoppingApp.Web.Models.Dtos
{
    public class ProductsDto //bir product un nesi varsa onu kullanmak istiyotum.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public  DateTime DateAdded { get; set; }
    }
}
