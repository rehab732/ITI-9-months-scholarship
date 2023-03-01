namespace SecApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            string str = "Rehab mohamed ahmed";
            char[] spearator = { ' ' };

            // using the method
            String[] strlist = str.Split(spearator);
            Array.Reverse(strlist);
            string  result = "";
            for(int i=0;i<strlist.Length;i++)
            {
                result+= strlist[i];
                result += " ";
            }
            Console.WriteLine(result);
            /*
            foreach (String s in strlist)
            {
                
                Console.Write(s+" ");
            }*/
            Console.ReadKey();
        }
    }
}