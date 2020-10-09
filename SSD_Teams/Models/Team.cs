// I, Quinn Helm, student number 000737479, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSD_Teams.Models
{
    public class Team
    {
        [Key, Display(Name = "Team ID")]
        public int ID { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required, EmailAddress, Display(Name = "Team Email")]
        public string Email { get; set; }

        [DataType(DataType.Date), Display(Name = "Established Date")]
        public DateTime? EstablishedDate { get; set; }
    }
}
