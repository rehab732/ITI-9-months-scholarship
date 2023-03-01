using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecDemo.Stratgy_Pattern
{
    public abstract class Duck
    {

        //child will take fly and Quack Behaviour through composition Not inheritance
        //Define all Behavior for Ducks 
        //step1-->Provide Fly Behavior Through Composition not through Inhetritance
        public IFlyBehavior ifly { get; set; }

        //Step2-->Develop against Abstraction (base class for Behavior )
        //Not against Concrete Implementation(any spacific Quack)
        public QuackingBehavior quacking { get; set; }//base not child 

        public  Duck(IFlyBehavior fly,QuackingBehavior quack)
        {
            ifly = fly;
            quacking = quack;
        }

        //step3-->Delegation
        public void Fly()
        {
            //delegate fly behavior to stategy object
            ifly.PerformFly();
        }
        public void Quack() => quacking.performQuack();

        public void Swim() => Console.WriteLine("Swimming");
        public abstract void Display();
    }
}
