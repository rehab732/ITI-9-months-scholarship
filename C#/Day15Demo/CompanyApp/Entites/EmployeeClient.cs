using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Entites
{
    public class EmployeeClient
    {
        
        public int EmpID { get; set; }
        public int ClientID { get; set; }

        public virtual Employee Employee { get; set; }  
        public virtual Client Client { get; set; }
        public DateTime Visit { get; set; }

    }
}
