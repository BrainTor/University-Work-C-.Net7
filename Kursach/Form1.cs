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
        public Form1()
        {
            InitializeComponent();
            st = new State_Classs();
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
            st.set_state("Sort");
            vs.show_start(toView_form, toView, list_items,  toView_state);
            
        }

        private void open_add(object sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Name;
            MessageBox.Show(name);
            if (st.get_state().Equals("start"))
            {
                if (!name.Equals("start"))
                {
                    MessageBox.Show("ƒл€ начала вы должны заполнить начальные данные");
                    return;
                }
            }
            add_data_form add = new add_data_form(name);
            add.ShowDialog();
        }

    }
}