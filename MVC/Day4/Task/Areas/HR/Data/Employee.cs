using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Linq;
using System.Web;

namespace Task.Areas.HR.Data
{
    public enum Gender { Male,Female}
    [Table("EmployeeInfo")]
    public class Employee
    {
        [Key]
        public int Empid { get; set; }

        [Required(ErrorMessage = "Must Enter Your Name")]
        [MaxLength(20,ErrorMessage = "Too Long name Must be less than 20 char")]
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }


        [Required(ErrorMessage = "Must Enter Your UserName")]
        [MaxLength(10, ErrorMessage = "Too Long username Must be less than 10 char")]
        [Display(Name = "Employee User Name")]
        public string EmpUsername { get; set; }

        [Required(ErrorMessage ="Must Enter Password")]
        [DataType(DataType.Password)]
        public string EmpPassword { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender EmpGender { get; set; }

        [Required(ErrorMessage ="Enter Your Email")]
        [DataType(DataType.EmailAddress)]
        public string EmpEmail { get; set; }

        [Required,DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime EmpJoinDate { get; set; }

        public int EmpSalary { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string EmpPhoneNumber { get; set; }  

    }
}