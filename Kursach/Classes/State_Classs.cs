using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Classes
{
    internal class State_Classs
    {
        private string state;
        private List<int> list_values;
        private Button[] button_elements;
        private int number_of_operation;
        public bool isOver = false;
        public State_Classs(List<int> list_values, Button[] button)
        {
            state = "start";
            this.list_values = list_values;
            this.button_elements = button;
            number_of_operation = 0;
        }

        public string get_state()
        {
            return state;
        }
        public void set_state(string state)
        {
            this.state = state;
        }

        public void set_Array(List<int> commingValues)
        {
            list_values = commingValues;
        }
        public List<int> get_list_values()
        {
            return list_values;
        }
        public void set_Button_Array(Button[] buttons)
        {
            button_elements = buttons;
        }
        public Button[] get_Button_Array()
        {
            return button_elements;
        }
        public void set_number_of_operation(int number)
        {
            number_of_operation = number;
        }
        public int get_number_of_operation()
        {
            return number_of_operation;

        }
      }
    }
