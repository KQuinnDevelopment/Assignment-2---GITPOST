// I, Quinn Helm, student number 000737479, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSD_Teams.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, EmailAddress, Display(Name = "Email Address")]
        public override string Email { get; set; }

        [Phone, Display(Name = "Phone Number")]
        public override string PhoneNumber { get; set; }

        [DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }
    }
}