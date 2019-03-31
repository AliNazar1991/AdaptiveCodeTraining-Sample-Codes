using System;
using System.Collections.Generic;

namespace AdaptiveCodeTraining.CompositePattern
{
    public class CompositeComponent : IComponent
    {
        private ICollection<IComponent> children;
        public CompositeComponent()
        {
            children = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            children.Add(component);
        }

        
        public void Something()
        {
            foreach (var child in children)
            {
                child.Something();
            }
        }

    }
}
