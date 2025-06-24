using System.ComponentModel.DataAnnotations;

namespace My_Shop.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4,ErrorMessage ="Yêu cầu nhập ID Danh mục")]
        public string Name { get; set; }
		[Required, MinLength(2, ErrorMessage = "Yêu cầu nhập tên Danh mục")]
		public string Description { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Mô tả Danh mục")]
		public string Slug { get; set; }
        public int Status { get; set; }
    }
}
