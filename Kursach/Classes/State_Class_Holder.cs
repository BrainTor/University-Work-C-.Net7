using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kursach.Classes
{


    [Serializable]
    public class ListContainer
    {
        public List<List<int>> Data { get; set; }
    }


    internal class State_Class_Holder
    {
        private List<State_Classs> state_list;

        public State_Class_Holder(State_Classs first_state)
        {
            state_list = new List<State_Classs>
            {
                first_state
            };
        }

        public State_Classs get_state_by_index(int index)
        {
            return state_list[index];
        }
        public int get_count()
        {
            return state_list.Count;
        }
        public void set_state(State_Classs state)
        {
            state_list.Add(state);
        }
        public void set_buttons_form_load(Button[] buttons)
        {
            foreach (var item in state_list)
            {
                item.set_Button_Array(buttons);
            }
        }
       
      }
    }

