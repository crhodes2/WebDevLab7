using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace webapp3.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "MiddleInitial")]
        public string MiddleInitial { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Years In School")]
        public int YearsInSchool { get; set; }
        [Required]
        [Display(Name = "Biography")]
        public string Biography { get; set; }

        //public User(int Id, string FirstName, string MiddleInitial, string LastName, string Email, int YearsInSchool, string Biography)
        //{
        //    this.Id = Id;
        //    this.FirstName = FirstName;
        //    this.MiddleInitial = MiddleInitial;
        //    this.LastName = LastName;
        //    this.Email = Email;
        //    this.YearsInSchool = YearsInSchool;
        //    this.Biography = Biography;
        //}

        
    }
}