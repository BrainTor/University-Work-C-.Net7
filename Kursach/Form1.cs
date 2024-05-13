using Kursach.Classes;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Kursach
{
    public partial class Form1 : Form
    {
        static State_Classs st;
        static Visual_Class vs;
        static Label toView;
        static Form1 toView_form;
        static Label toView_state;
        static State_Class_Holder state_list;
        public Form1()
        {
            InitializeComponent();
            st = new State_Classs(null, null);
            vs = new Visual_Class();
            toView = label3;
            toView_form = this;
            toView_state = label2;
        }

        private void open_info(object sender, EventArgs e)
        {
            info info = new info();
            info.Show();
        }


        public static void recive_data_start(List<int> list_items)
        {

            Button[] button = null;
            if (st.get_state().Equals("start"))
                button = vs.show_start(toView_form, toView, list_items, toView_state);
            else
            {
                Button[] to_new_state = vs.update_Buttons_Row(toView_form, list_items);
                st = new State_Classs(list_items, to_new_state);
            }
            st.set_state("Sort");
            st.set_Array(list_items);
            st.set_Button_Array(button);
            state_list = new State_Class_Holder(new State_Classs(st.get_list_values(), st.get_Button_Array()));
            state_list.get_state_by_index(state_list.get_count() - 1).set_state("Sort");
        }
        public static void recive_data_add(int index, int value)
        {
            if(index == 0 || st.get_list_values().Count <= index)
            {
                MessageBox.Show("Введены не верные данные, попробуйте еще раз");
                return;
            }
            List<int> temp_array = st.get_list_values();
            temp_array.Insert(index, value);
            Button[] to_new_state = vs.update_Buttons_Row(toView_form, temp_array);
            st = new State_Classs(temp_array, to_new_state);
            st.set_state("Add");
            state_list = new State_Class_Holder(new State_Classs(st.get_list_values(), st.get_Button_Array()));
            state_list.get_state_by_index(state_list.get_count() - 1).set_state("Add");
            toView_state.Text = "Добавление";
        }
        public static void recive_data_delete(int index)
        {
            List<int> temp_array = st.get_list_values();
            if (index == 0 || temp_array.Count <= index)
            {
                MessageBox.Show("Введены не верные данные, попробуйте еще раз");
                return;
            }
            temp_array.Remove(
                temp_array[index]
                );
            Button[] to_new_state = vs.update_Buttons_Row(toView_form, temp_array);
            st = new State_Classs(temp_array, to_new_state);
            st.set_state("Delete");
            state_list = new State_Class_Holder(new State_Classs(st.get_list_values(), st.get_Button_Array()));
            state_list.get_state_by_index(state_list.get_count() - 1).set_state("Delete");
            toView_state.Text = "Удаление";
        }
        private void open_add(object sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Name;
            if (st.get_state().Equals("start"))
            {
                if (!name.Equals("start"))
                {
                    MessageBox.Show("Для начала вы должны заполнить начальные данные");
                    return;
                }
            }
            add_data_form add = new add_data_form(name);
            add.ShowDialog();
        }
        private void before_and_after(object sender, EventArgs e){
            string name = (((ToolStripMenuItem)sender).Name);
            Realizator_Class realize = new Realizator_Class();
            Class_Controll controll = new Class_Controll();
            if (st.get_state().Equals("start"))
            {
                MessageBox.Show("Для начала заполните начальные данные");
                return; 
            }
            toView_state.Text = "Сортировка";
            Class_Parametr param = new Class_Parametr(st.get_number_of_operation(), st.get_list_values());
            if (name.Equals("after"))
            {
                if (st.isOver)
                {
                    MessageBox.Show("Массив полностью отсортирован");
                    return;
                }
                st = controll.realize_to_front(realize, param, st.get_Button_Array(),state_list);
                vs.reveiw_button(this, st, "");
            }
            else if(name.Equals("before"))
            {
                st = controll.realize_to_back(realize, param, st.get_Button_Array(), state_list);
                vs.reveiw_button(this, st,"b");
                state_list.set_state(new State_Classs(st.get_list_values() , st.get_Button_Array()));
            }
        }

        private void reload(object sender, EventArgs e)
        {
            if (state_list.get_count() == 1) {
                MessageBox.Show("Вы и так в начале");
                return;
            }
            st = state_list.get_state_by_index(0);
          
                  
            Button[] to_new_state = vs.update_Buttons_Row(toView_form, st.get_list_values());
            st = new State_Classs(st.get_list_values(), to_new_state);
            st.set_state("Sort");
            state_list = new State_Class_Holder(new State_Classs(st.get_list_values(),to_new_state));
            state_list.get_state_by_index(0).set_state("Sort");

        }
    }
}