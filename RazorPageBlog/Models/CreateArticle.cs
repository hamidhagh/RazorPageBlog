using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RazorPageBlog.Models
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage = "عنوان مقاله اجباری است")]
        public string Title { get; set; }
        [DisplayName("مسیر عکس")]
        [Required(ErrorMessage = "عکس مقاله اجباری است")]
        public string Picture { get; set; }
        [DisplayName("Alt عکس")]
        public string PictureAlt { get; set; }
        [DisplayName("عنوان عکس")]
        public string PictureTitle { get; set; }
        [DisplayName("توضیحات کوتاه")]
        [Required(ErrorMessage = "توضیحات کوتاه مقاله اجباری است")]
        public string ShortDescription { get; set; }
        [DisplayName("متن مقاله")]
        public string Body { get; set; }
    }
}
