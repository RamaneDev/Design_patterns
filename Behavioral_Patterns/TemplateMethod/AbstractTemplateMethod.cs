using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.TemplateMethod
{
         /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    public abstract class AbstractTemplateMethod
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        // The "Template method"
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}