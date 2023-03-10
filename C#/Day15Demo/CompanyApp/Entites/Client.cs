using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyApp.Entites
{
    public class Client
    {
        public int CID { get; set; } 
        public string FName { get; set; }
        public string LName { get; set; }
        public string MName { get; set; }
        public DateTime Timestamp { get; }=DateTime.Now;
        public decimal Deposit { get; set; }    


    }
}
