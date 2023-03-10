using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Demo.Entites
{
    [Table("Library Branches")]
    public class Branch
    {
        [Key]
        public int BID { get; set; }//not mapped by default
       
        [MaxLength(40)]
        public string City { get; set; }

        [MaxLength(20)]
        [Required]

        public string? Zipcode { get; set; }

        [Column(TypeName ="smallint")]
        public int Openhour { get; set; }

        public virtual ICollection<Title> Titles { get; set; }=new HashSet<Title>();    


    }
}
