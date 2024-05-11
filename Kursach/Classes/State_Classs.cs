using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Classes
{
    internal class State_Classs
    {
       private  string state;
        public State_Classs()
        {
            state = "start";
        }

     public string get_state ()
        {
            return state; 
        }
      public void set_state (string state) 
        {
            this.state = state;  
        }
    }
}
