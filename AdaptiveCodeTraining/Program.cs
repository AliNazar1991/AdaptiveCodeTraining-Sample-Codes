using AdaptiveCodeTraining.Fluent_Interfaces;
using AdaptiveCodeTraining.Mixins;
using AdaptiveCodeTraining.The_object_adapter_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            FluentImplementation flimpl = new FluentImplementation();
            FluentClient fclient = new FluentClient(flimpl);

            fclient.Run();


            Console.ReadKey();
        }
    }
}
