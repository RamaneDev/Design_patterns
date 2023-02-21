using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.Visitor
{
     /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    public class ConcreteElementA : Element
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
        public void OperationA()
        {
        }
    }
}