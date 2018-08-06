using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCodeTraining.Fluent_Interfaces
{
    public interface IFluentInterface
    {
        IFluentInterface DoSomething();
        IFluentInterface DoSomethingElse();

        void ThisMethodIsNotFluent();
    }
}
