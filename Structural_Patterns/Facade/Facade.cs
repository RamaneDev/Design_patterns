using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Design_patterns.Structural_Patterns.Facade.SubSystem1;
using Design_patterns.Structural_Patterns.Facade.SubSystem2;
using Design_patterns.Structural_Patterns.Facade.SubSystem3;
using Design_patterns.Structural_Patterns.Facade.SubSystem4;

namespace Design_patterns.Structural_Patterns.Facade
{
     /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }
        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}