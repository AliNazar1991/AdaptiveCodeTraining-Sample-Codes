using System;
namespace AdaptiveCodeTraining.DecoratorPattern
{
    public class ConcreteComponent : IComponent
    {
        public ConcreteComponent()
        {
        }

        public void Something()
        {
            Console.WriteLine("this is something");
        }
    }
}
