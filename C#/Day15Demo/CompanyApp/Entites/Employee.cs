using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Entites
{
    public class Employee
    {
        public int ID { get; set; }//by default pk for this table
        [MaxLength(40)]
        public string FName { get; set; }
        [StringLength(2,MinimumLength =2)]
        public string MName { get; set; }
        [MaxLength(40)]

        public string LName { get; set; }
        [Column(TypeName="Money")]
        public decimal Salary { get; set; }
        [NotMapped]
        public string FullName { get => $"{FName}{MName ?? string.Empty}{LName}"; }

        public virtual Branch? Branch { get; set; }
        public virtual ICollection<EmployeeClient> EmployeeClients { get; set; }=new HashSet<EmployeeClient>();

    }
}
