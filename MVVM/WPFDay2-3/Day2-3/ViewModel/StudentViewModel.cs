using Day2_3.DataService;
using Day2_3.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_3.ViewModel
{
   public class StudentViewModel:BasViewModel
    {
        public ObservableCollection<Student> StudentList { get; set; }
        public IDataService DataService;
        public StudentViewModel(IDataService dataService)
        {
            this.DataService = dataService;
            StudentList = new();
        }

        public void GetData()
        {
          var students=  DataService.GetAllStudents();
            StudentList.Clear();
            foreach (var student in students)
            {
                StudentList.Add(student);
            }
        }
    }
}
