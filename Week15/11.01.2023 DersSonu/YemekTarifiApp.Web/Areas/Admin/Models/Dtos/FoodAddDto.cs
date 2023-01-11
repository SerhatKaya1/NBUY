using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using YemekTarifiApp.Entity;

namespace YemekTarifiApp.Web.Areas.Admin.Models.Dtos
{
    public class FoodAddDto
    {
        [DisplayName("Yemek Adı")]
        [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmamalıdır.")]
        [MaxLength(100, ErrorMessage = "{0}, {1} karakterden uzun olmamalıdır.")]
        public string Name { get; set; }

        [DisplayName("Yemek Malzemesi")]
        [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmamalıdır.")]
        [MaxLength(100, ErrorMessage = "{0}, {1} karakterden uzun olmamalıdır.")]
        public string Material { get; set; }

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmamalıdır.")]
        [MaxLength(500, ErrorMessage = "{0}, {1} karakterden uzun olmamalıdır.")]
        public string Description { get; set; }

        [DisplayName("Meterial")]
        [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmamalıdır.")]
        [MaxLength(500, ErrorMessage = "{0}, {1} karakterden uzun olmamalıdır.")]
        public string Metarial { get; set; }

        [DisplayName("Yemek Resmi")]
        [Required(ErrorMessage = "{0} seçilmelidir.")]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Anasayfa Yemeği")]
        public bool IsHome { get; set; }

        [DisplayName("Onaylı Yemek")]
        public bool IsApproved { get; set; }

        [DisplayName("Kategoriler")]
        public List<Category> Categories { get; set; }

        [Required(ErrorMessage = "En az bir kategori seçilmelidir.")]
        public List<Category> SelectedCategories { get; set; }
    }
}
