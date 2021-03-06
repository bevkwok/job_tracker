using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JobTracker.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set;}
        
        [MinLength(2, ErrorMessage = "Username must contain at least 2 character")]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string Username {get; set;}

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        public string Email {get; set;}


        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must have at least 8 characters.")]
        [Column("Password", TypeName = "LONGTEXT")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage="Password must contain at least 1 number, 1 letter and a special character")]
        public string Password {get; set;}

        [Required(ErrorMessage = "Confirm Password is required")]
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword {get; set;}
        
        public List<Job> AppliedJobs { get; set; }

        public List<Contact> Contacts { get; set; }
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdateAt {get; set;} = DateTime.Now;
    }
}