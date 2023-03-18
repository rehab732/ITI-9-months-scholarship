using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task1.Model
{
    public class Student
    {
        /*- ID
        - Name
        - Gender
        - email
        - phoneNum
        - Birthdate*/
        
            [Key]
            public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Sorry Too Long Name ")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNum { get; set; }=string.Empty;
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Birthdate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public virtual ICollection<Course> Cources { get; } = new List<Course>();




    }
}
