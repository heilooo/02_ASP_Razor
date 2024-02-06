using System.ComponentModel.DataAnnotations;

namespace app8_razor.Models
{
    public class Article
    {
        [Key]public int Id { get; set; }
        [Required(ErrorMessage ="عنوان اجباری است!")]
        [Display(Name ="عنوان مقاله")]
        public string Title { get; set; }
        [Required(ErrorMessage = "تصویر اجباری است!")]
        [Display(Name = "تصویر")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "متن جایگزین تصویر اجباری است!")]
        [Display(Name = "متن جایگزین تصویر")]
        public string PictureAlt { get; set; }
        [Required(ErrorMessage = "عنوان تصویر اجباری است!")]
        [Display(Name = "عنوان تصویر")]
        public string PictureTitle { get; set; }
        [Required(ErrorMessage = "توضیح کوتاه اجباری است!")]
        [Display(Name = "توضیح کوتاه")]
        public string ShortDescription { get; set; }
        [Required(ErrorMessage = "متن اجباری است!")]
        [Display(Name = "متن مقاله")]
        public string Body { get; set; }
        public DateTime Created_at { get; set; }= DateTime.Now;
        public DateTime Updated_at { get; set; }

    }
}
