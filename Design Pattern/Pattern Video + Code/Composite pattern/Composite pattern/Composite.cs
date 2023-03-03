using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    public class Composite : Component
    {

        private List<Component> children = new List<Component>();

        public void Add(Component component)
        {
            children.Add(component);
        }

        public void Remove(Component component)
        {
            children.Remove(component);
        }

        public override string Operation()
        {
            List<string> results = new List<string>();
            foreach (Component child in children)
            {
                results.Add(child.Operation());
            }
            return $"Composite({string.Join("+", results)})";
        }
    }
}
