using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.Bridge
{
    public abstract class PenAbstraction
    {
        protected string penColor;

        public PenAbstraction(string color)
        {
            this.penColor = color;
        }

        public PenAbstraction()
        {
            this.penColor = "black";
        }
        public virtual void Draw(string shapeName)
        {
             Console.WriteLine(string.Format("{0} is drawn by a {1} pen color ", shapeName, penColor));
        }
    }
}