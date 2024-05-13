using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Classes
{
    internal class Class_Controll
    {
        public State_Classs realize_to_front(Realizator_Class real, Class_Parametr param, Button[] buttons, State_Class_Holder state_list) {
           
            param =  real.ToForvard(param);
            State_Classs state = new State_Classs(param.List, buttons);
            state.set_number_of_operation(param.index);
            state.set_state("Sort");
            state.isOver = param.isOver;
            state_list.set_state(state);
            
            return state;
        }

        public State_Classs realize_to_back(Realizator_Class real, Class_Parametr param, Button[] buttons, State_Class_Holder state_list)
        {
            
            param = real.toBack(param);
            State_Classs state = new State_Classs(param.List, buttons);
            state.set_number_of_operation(param.index);
            state.set_state("Sort");
            state_list.set_state(state);
            return state;
        }
    }


}
