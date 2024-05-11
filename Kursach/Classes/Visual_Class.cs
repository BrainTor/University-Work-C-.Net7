using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                WrapContents = false // Отключение переноса элементов
            };

            // Добавление кнопок в FlowLayoutPanel
            foreach (var item in list)
            {
                Button button = new Button
                {
                    Text = $"{item}",
                    Name = "button_show" + counter,
                    Margin = new Padding(5), // Отступы вокруг кнопки
                    Size = new Size(80, 40) // Размер кнопок
                };
                Buttons.Add(button);
                flowPanel.Controls.Add(button);
                counter++;
            }

       

            // Добавление FlowLayoutPanel на форму
            main_form.Controls.Add(flowPanel);
            return Buttons.ToArray();
        }
   
    }
}
