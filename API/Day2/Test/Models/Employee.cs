using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [ForeignKey("dept")]
        public int DeptId { get; set; }
        //navigation Property
        public virtual Department dept { get; set; }
    }
}
