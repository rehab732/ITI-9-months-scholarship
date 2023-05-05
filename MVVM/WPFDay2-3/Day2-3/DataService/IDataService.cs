using Day2_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_3.DataService
{
    public interface IDataService
    {
        IEnumerable<Student> GetAllStudents();

    }
}
