using System.ComponentModel.DataAnnotations;

namespace Core6Mvc.Models.DTO.Product
{
    public class ProductCreateDTO
    {
        [Required(ErrorMessage = "Product Name Bos olamaz")]
        [MinLength(2, ErrorMessage = "2 de az karakter iceremez")]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitePrice { get; set; }
        public int UnitsInStock { get; set; }


    }
}
