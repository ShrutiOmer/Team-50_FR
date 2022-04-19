using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Flight_Reservation.Models
{
    [Table("TblUser")]
    public class User
    {
        
        
        
            [Key]
            public int UserId { get; set; }
            [Required]
            [Display(Name = "First Name")]

            public string FirstName { get; set; }

            [Display(Name = "Last Name")]

            public string LastName { get; set; }

            [Display(Name = "Email ID")]
            [DataType(DataType.EmailAddress)]

            public string Email { get; set; }

            [DataType(DataType.Password)]

            public string Password { get; set; }


            

            [Required]
            [Range(18, 120)]

            public int Age { get; set; }

            [Display(Name = "Phone No")]

            public string Phoneno { get; set; }
        }

    
}