using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.Bridge
{
    public abstract class ShapeAbstraction
    {
        protected PenAbstraction penAbstraction;
        protected string shapeName;

        public ShapeAbstraction(string shapeName)
        {
            this.shapeName = shapeName;
        }

        public PenAbstraction PenAbstraction
        {
            set { penAbstraction = value; }
        }   


        public virtual void Draw()
        {
            penAbstraction.Draw(shapeName);
        } 
    }
}