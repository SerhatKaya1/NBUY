using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }
        [DisplayName("Kategori Ad")]
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} en az {1} karakter uzunluğunda olmalıdır.")]
        [MaxLength(50, ErrorMessage = "{0},{1} karakterden uzun olmalıdr.")]
        public string Name { get; set; }


        [DisplayName("Kategori Url")]
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır.")]

        public string Description { get; set; }
        public object Url { get; internal set; }
    }
}
