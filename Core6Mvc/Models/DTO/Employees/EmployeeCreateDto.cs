using System.ComponentModel.DataAnnotations;

namespace Core6Mvc.Models.DTO.Employees
{
    public class EmployeeCreateDto
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Ad alani boş gecilemez")]
        [StringLength(maximumLength: 50, ErrorMessage = "Ad alani 50 karakterden büyük olamaz")]
        [MinLength(2, ErrorMessage = "Ad Alani 2 den az olamaz")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alani boş gecilemez")]
        [StringLength(maximumLength: 50, ErrorMessage = "Ad alani 50 karakterden büyük olamaz")]
        [MinLength(2, ErrorMessage = "Soyad 2 az karakter olamaz")]
        public string? LastName { get; set; }

        public string? Title { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? HomePhone { get; set; }
    }
}
