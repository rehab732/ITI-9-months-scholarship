using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcePooling
{
    public class Resource : IDisposable
    {
        public string Name { get; set; }
        private ResourcePool ResourcePool;
        internal Resource(ResourcePool resourcePool, string name)
        {
            Name = name;
            ResourcePool = resourcePool;
            Console.WriteLine($"Creating Resource {ResourcePool.GetHashCode()} : {Name} Started ....");
            Thread.Sleep(2500);
            Console.WriteLine($"Creating Resource {ResourcePool.GetHashCode()} : {Name} Ended");
        }

        public void Dispose()
        {
            ResourcePool.AddToPool(this);
        }
    }
}
