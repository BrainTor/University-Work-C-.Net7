using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kursach
{
    public partial class add_data_form : Form
    {
        public delegate void Strart_Transfer_Delegate(List<int> list_items);
        public event Strart_Transfer_Delegate Start_TransferEvent;

        public delegate void Add_Transfer_Delegate(int value);
        public event Add_Transfer_Delegate Add_TransferEvent;

        public delegate void Delete_Transfer_Delegate(int index);
        public event Delete_Transfer_Delegate Delete_TransferEvent;

        public add_data_form(string data)
        {
            InitializeComponent();

            switch (data)
            {
                case "start":
                    title.Text = "Внесите основные данные";
                    start.Visible = true;
                    break;
                case "delete":
                    delete.Visible = true;
                    title.Text = "Удаление ячейки по номеру";
                    break;
                case "add":
                    add.Visible = true;
                    title.Text = "Добавление ячейки по номеру";
                    break;
            }
            Start_TransferEvent += Form1.recive_data_start;
            Add_TransferEvent += Form1.recive_data_add;
            Delete_TransferEvent += Form1.recive_data_delete;

        }
        public void sendData(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "but_start":
                    if (string.IsNullOrEmpty(textBox1.Text))
                    {
                        MessageBox.Show("Вы не ввели элементы списка");
                        return;
                    }
                    else if (numericUpDown1.Value <= 0)
                    {
                        MessageBox.Show("Вы ввели не верный размер массива");
                        return;
                    }
                    List<string> values = new List<string>();
                    values.AddRange(textBox1.Text.Split(','));
                    if (values.Count != numericUpDown1.Value)
                    {
                        MessageBox.Show("Вы ввели значений больше чем нужно :)");
                        return;
                    }
                    List<int> int_values = new List<int>();
                    foreach (var item in values)
                    {
                        try
                        {
                            int_values.Add(int.Parse(item));
                        }
                        catch
                        {
                            MessageBox.Show("Неверно введены элементы списка");
                        }
                    }
                    Start_TransferEvent?.Invoke(int_values);
                    Close();
                    break;
                case "but_delete":
                    Delete_TransferEvent?.Invoke((int)numericUpDown5.Value);
                    Close(); ;
                    break;
                case "but_add":
                   
                    Add_TransferEvent?.Invoke((int)numericUpDown3.Value);
                    Close();
                    break;
            }
        }



    }
}
