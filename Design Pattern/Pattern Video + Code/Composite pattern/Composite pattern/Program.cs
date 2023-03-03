using Composite_pattern;

internal class Program
{
        private static void Main(string[] args)
        {
        ///////////tree structure
       
        Composite tree = new Composite();//root
        
        Composite branch1 = new Composite();
        Composite branch = new Composite();



        branch1.Add(new Leaf());
        branch1.Add(new Leaf());
        branch1.Add(branch);
        

        Composite branch2 = new Composite();
        branch2.Add(new Leaf());

        tree.Add(branch1);
        tree.Add(branch2);

        // Client code can work with simple or complex components identically.
        Console.WriteLine($"RESULT: {tree.Operation()}");
    }
    }
