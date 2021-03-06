﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PghTechFest.Www.Models.Domain
{
    [Table("People")]
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        public string Bio { get; set; }
        
        public string AvatarUrl { get; set; }
        
        [Display(Name = "Twitter Username")]
        public string TwitterUserName { get; set; }
        
        public string Comments { get; set; }
    }
}
