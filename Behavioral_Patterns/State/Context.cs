using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.State
{
     public class Context
    {
        AbstractState state;
        // Constructor
        public Context(AbstractState state)
        {
            this.State = state;
        }
        // Gets or sets the state
        public AbstractState State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}