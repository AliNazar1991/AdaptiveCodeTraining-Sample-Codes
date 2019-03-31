using System;
namespace AdaptiveCodeTraining.CompositePattern
{
    public class Leaf : IComponent
    {
        public Leaf()
        {
        }

        public void Something()
        {
            Console.WriteLine($"this is from leaf: {this.GetHashCode()}");
        }
    }
}
