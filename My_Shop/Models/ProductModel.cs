using System.ComponentModel.DataAnnotations;

namespace My_Shop.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập ID Sản phẩm")]
		public string Name { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Sản phẩm")]
        public string Slug { get; set; }
		public string Description { get; set; }
        public decimal Price { get; set; }
        public int BranId { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }
        public string Image {  get; set; }
        
    }
}
