using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Ad")]
        [Required(ErrorMessage ="{0}  boş bırakılmamalıdır.")]
        [MinLength(5,ErrorMessage =("{0} en az {1} karakter uzunluğunda olmalıdır."))]
        [MaxLength(50, ErrorMessage = ("{0},{1} karakterden uzun olmalıdr."))]
        public string Name { get; set; }



        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır.")]
        [MinLength(5, ErrorMessage = ("{0} en az {1} karakter uzunluğunda olmalıdır."))]
        [MaxLength(50, ErrorMessage = ("{0},{1} karakterden uzun olmalıdr."))]
        public string Description { get; set; }
        public object Url { get; internal set; }
    }
}
