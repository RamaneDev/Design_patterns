using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.ProxyPattern
{
       /// <summary>
    /// The 'Proxy' class
    /// </summary>
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            // Use 'lazy initialization'
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            checkRights();
            realSubject.Request();
        }

        private void checkRights()
        {
            Console.WriteLine("checking right before calling the RealSubject...");
        }
    }
}