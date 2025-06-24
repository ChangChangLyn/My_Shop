using Microsoft.EntityFrameworkCore;
using My_Shop.Models;

namespace My_Shop.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if (!_context.Products.Any())
			{
				CategoryModel macbook = new CategoryModel { Name = "macbook", Slug = "macbook", Description = "Macbook is Large Product in the world", Status=1};
				CategoryModel pc = new CategoryModel { Name = "Pc", Slug = "pc", Description = "Pc is Large Broduct in the world", Status=1};
				BrandModel apple = new BrandModel { Name = "Apple", Slug = "apple", Description = "Apple is Large Brand in the world", Status = 1 };
				BrandModel samsung = new BrandModel { Name = "Samsung", Slug = "Samsung", Description = "Samsung is Large Brand in the world", Status = 1 };
				_context.Products.AddRange(
					new ProductModel { Name = "Macbook", Slug = "Macbook", Description = "Macbook is Best", Image = "1.jpg", Category = macbook, Brand = apple, Price = 1300 },
					new ProductModel { Name = "Pc", Slug = "pc", Description = "Pc is Best", Image = "1.jpg", Category = pc, Brand = samsung, Price = 1500 }
				);
			}
			_context.SaveChanges();
		}
	}
}
