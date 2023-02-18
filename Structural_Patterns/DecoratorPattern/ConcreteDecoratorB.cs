using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.DecoratorPattern
{
  /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();           
            Console.WriteLine("ConcreteDecoratorB.Operation()");
            AddedBehavior();
        }
        void AddedBehavior()
        {   
             Console.WriteLine("Bhavior added from ConcreteDecoratorB !");        
        }
    }
}