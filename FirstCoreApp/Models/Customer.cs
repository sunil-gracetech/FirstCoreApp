using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name can't empty")]
        [MinLength(3, ErrorMessage = "Name must be Min 3 char !")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email can't empty")]
        [EmailAddress(ErrorMessage = "Invalid Email address !")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile number can't empty")]
        [RegularExpression("[0-9]{10}", ErrorMessage ="Mobile number is not valid !")]
        public string Mobile { get; set; }
    }
}
