using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Data_Annotaion_DemoWebApplication.Models
{
    public class Student
    {   
        [Required(ErrorMessage = "please enter the roll no ")]
      
        public int rno { get; set; }
        
        [Required(ErrorMessage = "please enter the name")]  
      //  [MinLength(5,ErrorMessage="minimum 5 char reaquired")]
      //  [MaxLength(10,ErrorMessage="Maximum 10 char limit")]
        [StringLength(10,MinimumLength=2,ErrorMessage=" please enter name between 2 to 10")]
        public string name { get; set; }
       
        [Required(ErrorMessage = "please enter the age ")]
        [Range(21, 30, ErrorMessage = "please enter name between 21 to 30")]
        public int age { get; set; }
      
        [Required(ErrorMessage = "please enter the mobaile no ")]
        [RegularExpression("[0-9]{09}",ErrorMessage="Invalid Mob. No")]
        public string mobileNumber { get; set; }

        [Required(ErrorMessage = "please enter the email address ")]
        [EmailAddress(ErrorMessage="Invalid Email")]
        public string emailAddress { get; set; }
               
        [Required(ErrorMessage = "please enter the password ")]
        public string password { get; set; }
 
        [Required(ErrorMessage = "please enter the confirm password ")]
        [Compare("password", ErrorMessage = "not matched")]
        public string confirmPassword { get; set; }
    }
}