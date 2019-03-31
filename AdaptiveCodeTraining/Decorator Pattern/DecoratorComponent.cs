using System;
namespace AdaptiveCodeTraining.DecoratorPattern
{
    public class DecoratorComponent : IComponent
    {
        private readonly IComponent decoratedComponent;

        public DecoratorComponent(IComponent decoratedComponent)
        {
            this.decoratedComponent = decoratedComponent;
        }

        public void Something()
        {
            SomethingElse();
            decoratedComponent.Something();  
        }
        private void SomethingElse()
        {
            Console.WriteLine("this is something else");
        }
    }
}
