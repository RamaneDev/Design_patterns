using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.TemplateMethod
{ 

        /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class ConcreteTemplateMethodA : AbstractTemplateMethod
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteTemplateMethodA.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteTemplateMethodA.PrimitiveOperation2()");
        }
    }
}