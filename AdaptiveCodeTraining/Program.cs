using AdaptiveCodeTraining.CompositePattern;
using AdaptiveCodeTraining.DecoratorPattern;
using AdaptiveCodeTraining.Fluent_Interfaces;
using AdaptiveCodeTraining.Mixins;
using AdaptiveCodeTraining.The_object_adapter_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IComponent = AdaptiveCodeTraining.CompositePattern.IComponent;

namespace AdaptiveCodeTraining
{
    class Program
    {
        // page 132
        static IExpectedInterface dependency = new Adapter(new TargetClass());

        static void Main(string[] args)
        {

            // page 138 - 139
            //var duck = new Duck();

            //foreach (var duckling in duck)
            //{
            //    Console.WriteLine($"Quack {duckling}");
            //}

            // page 132
            //dependency.MethodA();

            //page 142
            //targetImpl impl = new targetImpl();
            //MixinClient mixinclient = new MixinClient(impl);
            //mixinclient.Run();

            //page 145
            //FluentImplementation flimpl = new FluentImplementation();
            //FluentClient fclient = new FluentClient(flimpl);

            //fclient.Run();


            // page 231 - decorator pattern 
            // because the client accepts the interface as a method parameter, you can provide
            // either the original, undecorated type to that client or you can provide the decorated version
            //IComponent component = new DecoratorComponent(new ConcreteComponent());

            //component.Something();

            // page 232 - composite pattern
            // The composite pattern's purpose is to allow you to treat many instances of an interface as if they were just
            // one

            //IComponent component;
            //var composite = new CompositeComponent();
            //composite.AddComponent(new Leaf());
            //composite.AddComponent(new Leaf());
            //composite.AddComponent(new Leaf());

            //component = composite;
            //component.Something();
            
            Console.ReadLine();
        }
    }
}
