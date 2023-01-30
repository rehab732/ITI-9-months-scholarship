internal class Program
{
    public enum NICType
    {
        Ethernet, token
    }
    public class NIC
    {
        string Manufacture, macAddress;
        NICType type;
        NIC(string manufacture, string macAddresss,string t)
        {
            Manufacture = manufacture;
            macAddress = macAddresss;
            type = (NICType)Enum.Parse(typeof(NICType), t);
            Console.WriteLine("Constructor created");

        }
        public static NIC obj { get; } = new("XYZ", "123.356.767.", "Ethernet");



    }
    private static void Main(string[] args)
    {

        NIC n1;
        NIC n2;

        n1 = NIC.obj;
        n2 = NIC.obj;
      
        Console.WriteLine(n1.GetHashCode());
        Console.WriteLine(n2.GetHashCode());
    }
}