using System;
using AdaptiveCodeTraining.DecoratorPattern;

namespace AdaptiveCodeTraining.Lazydecorators
{
    public class LazyComponent : IComponent
    {
        public Lazy<IComponent> _LazyComponent { get; }

        public LazyComponent(Lazy<IComponent> lazyComponent)
        {
            _LazyComponent = lazyComponent;
        }

        public void Something()
        {
            _LazyComponent.Value.Something();
        }
    }

    // using lazycomponent

    public class ComponentClient
    {
        public IComponent _Component { get; }

        public ComponentClient(IComponent component)
        {
            _Component = component;
        }

        public void Run()
        {
            _Component.Something();
        }
    }
}
