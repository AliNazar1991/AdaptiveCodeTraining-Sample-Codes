using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCodeTraining.Mixins
{
    public class targetImpl : ITargetInterface
    {
        public void DoSomething()
        {
            Console.WriteLine("Do something executed");
        }
    }
}
