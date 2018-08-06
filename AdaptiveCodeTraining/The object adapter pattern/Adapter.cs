using AdaptiveCodeTraining.The_object_adapter_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCodeTraining.The_object_adapter_pattern
{
    public class Adapter : IExpectedInterface
    {
        private TargetClass target;
        public Adapter(TargetClass target)
        {
            this.target = target;
        }

        public void MethodA()
        {
            target.MethodB();
        }
    }
}
