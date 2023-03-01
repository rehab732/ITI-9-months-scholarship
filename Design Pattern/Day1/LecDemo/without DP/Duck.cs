using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecDemo.without_DP
{
    public abstract class Duck
    {
        public void Swim() => Console.WriteLine("Duck is Swimming");
        public void Fly()=> Console.WriteLine("Duck is Fly with normal speed");
        public void Quack()
        {
            Console.WriteLine("Duck is Quacking");
            Console.Beep();
        }
        public abstract void Display();
    }
}
