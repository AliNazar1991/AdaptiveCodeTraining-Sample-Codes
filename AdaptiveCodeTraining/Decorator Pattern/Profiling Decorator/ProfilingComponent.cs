using System;
using System.Diagnostics;

namespace AdaptiveCodeTraining.DecoratorPattern.ProfilingDecorator
{
    public class ProfilingComponent : IComponent
    {
        public ProfilingComponent(IComponent decoratedComponent)
        {
            DecoratedComponent = decoratedComponent;
            stopwatch = new Stopwatch();

        }

        public IComponent DecoratedComponent { get; }
        private readonly Stopwatch stopwatch;

        public void Something()
        {
            stopwatch.Start();
            DecoratedComponent.Something();
            stopwatch.Stop();
        }
    }
}
