using System.Threading.Channels;

namespace FirstApp {
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Enter size of array");
            int x=int.Parse(Console.ReadLine());
            int [] arr=new int [x];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Filled");

           
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {



                for (int j = arr.Length - 1; j > 0; j--)
                {

                    int dis = 0;

                    if (arr[j] == arr[i])
                    {

                        dis = j - i-1;
                        if (dis > max)
                        {
                            max = dis;
                        }


                        break;

                    }


                }


               
            }
           
            Console.WriteLine(max);




        }         
   

    }
}