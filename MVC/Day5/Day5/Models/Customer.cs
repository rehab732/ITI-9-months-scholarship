using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Day5.Models
{
    public class Customer
    {
        [Key]
        [Required]
        [RegularExpression("^\\d+$",ErrorMessage ="ID Must Be Integer")]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [CustomName]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email :)")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [CustomMinAge(20, 50)]
        public int Age { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]

        public Gender gender { get; set; }
    }
}