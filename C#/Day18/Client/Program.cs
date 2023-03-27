using ResourcePooling;
using System.Reflection;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResourcePool resourcePool1 = new ResourcePool() { MinSize = 1, MaxSize = 3 };
            Resource resource1 = resourcePool1.GetResource();
            Resource resource2 = resourcePool1.GetResource();
            Resource resource3 = resourcePool1.GetResource();
            resource1.Dispose();
            resource2.Dispose();
            resource3.Dispose();


            ResourcePool resourcePool2 = new ResourcePool();
            Resource resource11 = resourcePool2.GetResource();
            Resource resource12 = resourcePool2.GetResource();
            resource11.Dispose();
            resource12.Dispose();
        }
    }
}