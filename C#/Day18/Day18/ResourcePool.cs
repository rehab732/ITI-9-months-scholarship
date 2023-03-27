using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcePooling
{
    public class ResourcePool
    {
        public int MinSize { get; set; } = 1;
        public int MaxSize { get; set;} = 2;
        Queue<Resource> resourcesPool = new ();


        public ResourcePool()
        {
            for (int i = 0; i < MinSize; i++)
            {
                resourcesPool.Enqueue(new(this,GetHashCode().ToString()));
            }
        }

        public Resource GetResource()
        {
            if(resourcesPool.Count > 0)
                return resourcesPool.Dequeue();
            return new (this, GetHashCode().ToString());
        }

        public void AddToPool(Resource resource)
        {
            Console.WriteLine(resource.Name);
            if (resourcesPool.Count < MaxSize)
                resourcesPool.Enqueue(resource);

        }
    }
}
