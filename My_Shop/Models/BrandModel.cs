﻿using System.ComponentModel.DataAnnotations;

namespace My_Shop.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập ID Thương hiệu")]
		public string Name { get; set; }
		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Thương hiệu")]
		public string Description { get; set; }
        public string Slug { get; set; }
        public int Status { get; set; }
    }
}
