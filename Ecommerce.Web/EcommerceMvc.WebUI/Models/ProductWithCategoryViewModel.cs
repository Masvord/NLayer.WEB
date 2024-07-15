using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMvc.WebUI.Models
{
    public class ProductWithCategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public CategoryViewModel Category { get; set; }

    }
}
