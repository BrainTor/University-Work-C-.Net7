using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach.Classes
{
    internal class Visual_Class
    {

        public Button [] show_start(Form main_form, Label title_text, List<int> list, Label state)
        {
            main_form.Controls.Remove(title_text);
            state.Text = "Сортировка";
            int counter = 0;
            var Buttons = new List<Button>();
            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Location = new Point(main_form.Width/2 -225, main_form.Height / 2- 20),
                Size = new Size(600, 200),
                AutoScroll = true, // Включение скроллинга
                FlowDirection = FlowDirection.LeftToRight, // Направление потока
                WrapContents = false,// Отключение переноса элементов
                Name = "But_container"
            };

            // Добавление кнопок в FlowLayoutPanel
            foreach (var item in list)
            {
                Button button = new Button
                {
                    Text = $"{item}",
                    Name = "button_show" + counter,
                    Margin = new Padding(5), // Отступы вокруг кнопки
                    Size = new Size(80, 40),// Размер кнопок
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black
                };
                Buttons.Add(button);
                flowPanel.Controls.Add(button);
                counter++;
            }

       

            // Добавление FlowLayoutPanel на форму
            main_form.Controls.Add(flowPanel);
            return Buttons.ToArray();
        }


        public Button[] update_Buttons_Row(Form main_form, List<int> list)
        {
        
            int counter = 0;
            var Buttons = new List<Button>();
            FlowLayoutPanel main_frame = main_form.Controls.Find("But_container", true).FirstOrDefault() as FlowLayoutPanel;
            main_form.Controls.Remove(main_frame); 

            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Location = new Point(main_form.Width / 2 - 225, main_form.Height / 2 - 20),
                Size = new Size(600, 200),
                AutoScroll = true, // Включение скроллинга
                FlowDirection = FlowDirection.LeftToRight, // Направление потока
                WrapContents = false, // Отключение переноса элементов
                Name = "But_container"
            };

            // Добавление кнопок в FlowLayoutPanel
            foreach (var item in list)
            {
                Button button = new Button
                {
                    Text = $"{item}",
                    Name = "button_show" + counter,
                    Margin = new Padding(5), // Отступы вокруг кнопки
                    Size = new Size(80, 40), // Размер кнопок
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black
                };
                Buttons.Add(button);
                flowPanel.Controls.Add(button);
                counter++;
            }



            // Добавление FlowLayoutPanel на форму
            main_form.Controls.Add(flowPanel);
            return Buttons.ToArray();
        }

        public void reveiw_button(Form form, State_Classs state,string vector)
        {
                Button firstButton = form.Controls.Find("button_show" + state.get_number_of_operation(), true).FirstOrDefault() as Button;
                firstButton.Text = state.get_list_values()[state.get_number_of_operation()].ToString() ;
                firstButton.BackColor = Color.Green;
                firstButton.ForeColor = Color.White;
                Button secondBut = form.Controls.Find("button_show" + (state.get_number_of_operation()+1), true).FirstOrDefault() as Button;
                secondBut.Text = state.get_list_values()[state.get_number_of_operation()+1].ToString();
                secondBut.BackColor = Color.Red;
                secondBut.ForeColor = Color.White;
                for (int i = 0; i < state.get_list_values().Count; i++)
                {
                    if (i == state.get_number_of_operation() || i == state.get_number_of_operation() + 1)
                        continue;
                    Button temp_button = form.Controls.Find("button_show" + i, true).FirstOrDefault() as Button;
                    temp_button.BackColor = Color.Transparent;
                    temp_button.ForeColor = Color.Black; 
                }
            if (vector.Equals("b"))
            {
                firstButton = form.Controls.Find("button_show" + state.get_number_of_operation(), true).FirstOrDefault() as Button;
                firstButton.Text = state.get_list_values()[state.get_number_of_operation()].ToString();
                firstButton.BackColor = Color.Green;
                firstButton.ForeColor = Color.White;
                secondBut = form.Controls.Find("button_show" + (state.get_number_of_operation() -1 ), true).FirstOrDefault() as Button;
                secondBut.Text = state.get_list_values()[state.get_number_of_operation()-1].ToString();
                secondBut.BackColor = Color.Red;
                secondBut.ForeColor = Color.White;
                for (int i = 0; i < state.get_list_values().Count; i++)
                {
                    if (i == state.get_number_of_operation() || i == state.get_number_of_operation() + 1)
                        continue;
                    Button temp_button = form.Controls.Find("button_show" + i, true).FirstOrDefault() as Button;
                    temp_button.BackColor = Color.Transparent;
                    temp_button.ForeColor = Color.Black;
                }
            }
                    
        }
   
    }
}
