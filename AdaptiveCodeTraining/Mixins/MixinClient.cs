using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCodeTraining.Mixins
{
    public class MixinClient
    {
        private readonly ITargetInterface target;

        public MixinClient(ITargetInterface target)
        {
            this.target = target;
        }

        public void Run()
        {
            target.DoSomething();
            target.FirstExtensionMethod();
            target.SecondExtensionMethod();
            target.FurtherExtensionMethodA(30);
            target.FurtherExtensionMethodB("HELLO MA BOY!!!!!");
        }
    }
}
