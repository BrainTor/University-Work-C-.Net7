using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kursach.Classes
{



    internal class State_Class_Holder
    {
        private List<State_Classs> state_list;
        private const string file_name = "state_list.txt";
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

        public void save_list(string name)
        {
            if (name == "save_but")
            {
                using (StreamWriter writer = new StreamWriter(file_name))
                {
                    foreach (var list in state_list)
                    {

                        writer.WriteLine(string.Join(",", list.get_list_values()));
                    }
                
                    writer.WriteLine(state_list[state_list.Count-1].get_number_of_operation());
                    if (state_list[state_list.Count-1].isOver)
                        writer.WriteLine(1);
                    else 
                        writer.WriteLine(0);
                }
                MessageBox.Show("Данные успешно сохранены.");
            } else
            {
                if (File.Exists(file_name))
                {
                    state_list.Clear();
                    using (StreamReader reader = new StreamReader(file_name))
                    {
                        string line;
                        bool save_number = false;
                        while ((line = reader.ReadLine()) != null)
                        {
                            
                            List<int> list = line.Split(',').Select(int.Parse).ToList();
                            if (list.Count != 1)
                            {
                                State_Classs local_state = new State_Classs(list, null);
                                state_list.Add(local_state);
                            }
                            else
                            {
                                State_Classs  local_state = state_list[state_list.Count - 1];
                                if (!save_number)
                                {
                                    local_state.set_number_of_operation(list[0]);
                                    save_number = true;
                                    continue;
                                }
                                else
                                    local_state.isOver = list[0]==1?true:false;
                            }
                          
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Файл не найден.");
                }
            }
        }
       
      }
    }

