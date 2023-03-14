using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Day5.Models
{
    public class CustomName:ValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            if(obj==null)
            {
                return false;
            }
            else
            {
                if(obj is string s)
                {
                    if (Regex.IsMatch(s, "^([a-zA-Z]| )+$"))
                        return true;
                    else
                    {
                        ErrorMessage = "Your Name Must consist only letters and spaces";
                        return false;
                    }
                }
                else
                {
                    ErrorMessage = "Your Name Must Be String Only";
                    return false;
                }
            }
        }

    }
}