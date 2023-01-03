namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class SearchQueryDto
    {
        public bool? IsHome { get; set; }
        public int? IsApproved { get; set; }
        public int? SearchString { get; set;}
    }
}
