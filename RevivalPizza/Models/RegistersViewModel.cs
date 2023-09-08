using System.ComponentModel.DataAnnotations;

namespace RevivalPizza.Models
{
    public class RegistersViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string? Email { get; set; }
        public bool IsValidEmail { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string? PostalCode { get; set; }
        public bool IsDeliverable { get; set; }



    }
}
