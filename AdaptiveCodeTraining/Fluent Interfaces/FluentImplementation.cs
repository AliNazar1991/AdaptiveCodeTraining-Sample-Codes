using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCodeTraining.Fluent_Interfaces
{
    public class FluentImplementation : IFluentInterface
    {
        public IFluentInterface DoSomething()
        {
            Console.WriteLine(this);
            return this;
        }

        public IFluentInterface DoSomethingElse()
        {
            Console.WriteLine(this);
            return this;
        }

        public void ThisMethodIsNotFluent()
        {
            
        }
    }
}
